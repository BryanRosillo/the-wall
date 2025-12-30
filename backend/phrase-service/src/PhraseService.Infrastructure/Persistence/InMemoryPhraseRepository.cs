using PhraseService.Application.Ports;
using PhraseService.Domain.Entities;

namespace PhraseService.Infrastructure.Persistence
{
    public class InMemoryPhraseRepository : IPhraseRepository
    {
        private readonly List<Phrase> _phrases = new ();
        public Task SaveAsync(Phrase phrase)
        {
            _phrases.Add(phrase);
            return Task.CompletedTask;
        }
        
    }
}