using PhraseService.Domain.Entities;
using PhraseService.Application.Ports;
public class FakePhraseRepository : IPhraseRepository
{
    public Phrase? SavedPhrase {get; private set;}

    public Task SaveAsync(Phrase phrase)
    {
        SavedPhrase = phrase;
        return Task.CompletedTask;
    }
}