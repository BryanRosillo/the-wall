using PhraseService.Domain.ValueObjects;
using PhraseService.Application.UseCases.PublishPhrase;

public class PublishPhraseTests
{
    [Fact]
    public async Task PublishPhrase_saves_phrase()
    {
        var repository = new FakePhraseRepository();
        var useCase = new PublishPhraseUseCase(repository);

        var command = new PublishPhraseCommand{
            Text = "Hello world",
            UserId = "1",
            Style =  new Style("Arial", 10, "#0000FF")
        };

        await useCase.Execute(command);

        Assert.NotNull(repository.SavedPhrase);
        Assert.Equal("Hello world", repository.SavedPhrase.Text);
        Assert.Equal("1", repository.SavedPhrase.AuthorId);
    }
 
}