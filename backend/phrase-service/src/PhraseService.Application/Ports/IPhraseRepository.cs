using PhraseService.Domain.Entities;

namespace PhraseService.Application.Ports
{
    public interface IPhraseRepository
    {
        Task SaveAsync(Phrase phrase);
    }
}