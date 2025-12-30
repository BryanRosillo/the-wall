using PhraseService.Domain.ValueObjects;
using PhraseService.Application.UseCases.PublishPhrase;

public class PublishPhraseTests
{
    [Fact]
    public async Task PublishPhrase_saves_phrase()
    {
        var repository = new FakePhraseRepository();
        var useCase = new PublishPhraseUseCase(repository);

        var command = new PublishPhraseCommand
        {
            Text = "Hello world",
            UserId = "1",
            Style = new Style("Arial", 10, "#0000FF")
        };

        await useCase.Execute(command);

        Assert.NotNull(repository.Phrases);
        Assert.Equal("Hello world", repository.Phrases[0].Text);
        Assert.Equal("1", repository.Phrases[0].AuthorId);
    }

    [Fact]
    public async Task PublishPhrase_with_null_text()
    {
        var repository = new FakePhraseRepository();
        var useCase = new PublishPhraseUseCase(repository);

        var command = new PublishPhraseCommand
        {
            Text = null,
            UserId = "1",
            Style = new Style("Arial", 10, "#0000FF")
        };

        await Assert.ThrowsAsync<ArgumentNullException>(() => useCase.Execute(command));
    }

    [Fact]
    public async Task PublishPhrase_with_null_userId()
    {
        var repository = new FakePhraseRepository();
        var useCase = new PublishPhraseUseCase(repository);

        var command = new PublishPhraseCommand
        {
            Text = "Hi everyone",
            UserId = null,
            Style = new Style("Arial", 10, "#0000FF")
        };

        await Assert.ThrowsAsync<ArgumentNullException>(() => useCase.Execute(command));
    }

    [Fact]
    public async Task PublishPhrase_with_null_style()
    {
        var repository = new FakePhraseRepository();
        var useCase = new PublishPhraseUseCase(repository);

        var command = new PublishPhraseCommand
        {
            Text = "Hi everyone",
            UserId = "1",
            Style = null
        };

        await Assert.ThrowsAsync<ArgumentNullException>(() => useCase.Execute(command));
    }

}