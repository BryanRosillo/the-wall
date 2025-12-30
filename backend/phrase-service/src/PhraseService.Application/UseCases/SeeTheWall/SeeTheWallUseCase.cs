using PhraseService.Domain.Entities;
using PhraseService.Application.Ports;

namespace PhraseService.Application.UseCases.SeeTheWall
{
    public class SeeTheWallUseCase
    {
        private readonly IPhraseRepository _repository;

        public SeeTheWallUseCase(IPhraseRepository repository)
        {
            _repository = repository;
        }

        public async Task<IReadOnlyList<Phrase>> Execute()
        {
            return await _repository.GetAllAsync();
        }
    }
}