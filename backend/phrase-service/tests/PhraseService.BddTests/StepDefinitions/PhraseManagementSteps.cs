using System.Net.Http.Json;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Net.Http.Headers;
using FluentAssertions;

[Binding]
public class PhraseManagementSteps
{

    private readonly PhraseContext _context;
    public PhraseManagementSteps(PhraseContext context)
    {
        _context = context;
    }

    [Given(@"an authenticated user")]
    public void GivenAnAuthenticatedUser()
    {
        _context.AuthToken = "fake-token";
        _context.Phrase = new PhraseRequest();
        _context.Phrase.UserId = "1";
    }

    [Given(@"a phrase with non-empty text")]
    public void GivenAPhraseWithNonEmptyText()
    {
        _context.Phrase.Text = "Hello world";
    }

    [Given(@"the text length is less than 500 characters")]
    public void GivenTheTextLengthIsLessThan500Characters()
    {
        _context.Phrase.Text = new string('a', 499);
    }

    [Given(@"a style \(font, font size and color\)")]
    public void GivenAStyle()
    {
        _context.Phrase.Font = "Arial";
        _context.Phrase.FontSize = 10;
        _context.Phrase.Color = "#000000";
    }

    [When(@"the user publish the phrase")]
    public async Task WhenTheUserPublishThePhrase()
    {
        _context.Client!.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _context.AuthToken);
        _context.Response = await _context.Client.PostAsJsonAsync("/phrases", _context.Phrase);
    }

    [Then(@"it becomes visible to all users")]
    public async Task ThenItBecomesVisibleToAllUsers()
    {
        _context.Wall = await _context.Client.GetFromJsonAsync<List<WallItem>>("/wall");
        _context.Wall.Should().Contain(item => item.Text == _context.Phrase.Text);
    }

    [Then(@"it is associated with the posting user")]
    public void ThenItIsAssociatedWithThePostingUser()
    {
        var item = _context.Wall!.Single(item => item.Text == _context.Phrase!.Text);

        item.AuthorId.Should().NotBeNull();
    }

    [Then(@"the user’s name or alias is displayed.")]
    public void ThenTheUsersNameOrAliasIsDisplayed()
    {
        var item = _context.Wall!.Single(item => item.Text == _context.Phrase!.Text);

        item.AuthorId.Should().NotBeNull();
    }


}