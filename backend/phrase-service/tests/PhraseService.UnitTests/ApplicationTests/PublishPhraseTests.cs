using PhraseService.Domain.ValueObjects;
public class PublishPhraseTests
{
    [Fact]
    public async Task PublishPhrase_saves_phrase()
    {
        var repository = new FakePhraseRepository();
        var useCase = new PublishPhraseUseCase(repository);

        var command = new PublishPhraseCommand(
            text: "Hello world",
            style: new Style("Arial", 10, "#0000FF"),
            userId: "1" 
        );

        await useCase.Execute(command);

        Assert.NotNull(repository.SavedPhrase);
        Assert.Equal("Hello world", repository.SavedPhrase);
    }
 
}