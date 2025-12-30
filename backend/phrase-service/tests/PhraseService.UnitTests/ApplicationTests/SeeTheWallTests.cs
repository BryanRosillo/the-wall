using PhraseService.Domain.ValueObjects;
using PhraseService.Domain.Entities;
using PhraseService.Application.UseCases.SeeTheWall;
public class SeeTheWallTests
{
    [Fact]
    public async Task SeeTheWall_shows_phrases()
    {
        var repository = new FakePhraseRepository();

        var style = new Style("Arial", 10, "#0000FF");
        var phrase1 = new Phrase("The wall is amazing.", "1", style);
        var phrase2 = new Phrase("Hello users.", "2", style);

        await repository.SaveAsync(phrase1);
        await repository.SaveAsync(phrase2);


        var useCase = new SeeTheWallUseCase(repository);

        var phrases = await useCase.Execute();

        Assert.Equal(2, phrases.Count);
        Assert.Equal("The wall is amazing.", phrases[0].Text);
        Assert.Equal("Hello users.", phrases[1].Text);
    }

    [Fact]
    public async Task SeeTheWall_with_no_phrases()
    {
        var repository = new FakePhraseRepository();

        var useCase = new SeeTheWallUseCase(repository);

        var phrases = await useCase.Execute();

        Assert.Empty(phrases);
    }

    [Fact]
    public async Task SeeTheWall_shows_authors()
    {
        var repository = new FakePhraseRepository();

        var style = new Style("Arial", 10, "#0000FF");
        var phrase1 = new Phrase("The wall is amazing.", "1", style);

        await repository.SaveAsync(phrase1);

        var useCase = new SeeTheWallUseCase(repository);

        var phrases = await useCase.Execute();

        Assert.Equal("1", phrases[0].AuthorId);
    }

}
