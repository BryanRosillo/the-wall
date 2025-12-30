using PhraseService.Domain.Entities;
using PhraseService.Application.Ports;
public class FakePhraseRepository : IPhraseRepository
{
    public readonly List<Phrase> Phrases = new();

    public Task SaveAsync(Phrase phrase)
    {
        Phrases.Add(phrase);
        return Task.CompletedTask;
    }

    public Task<IReadOnlyList<Phrase>> GetAllAsync()
    {
        return Task.FromResult((IReadOnlyList<Phrase>)Phrases);
    }
}