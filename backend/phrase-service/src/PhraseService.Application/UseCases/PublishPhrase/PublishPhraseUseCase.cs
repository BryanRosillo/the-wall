using PhraseService.Domain.Entities;
using PhraseService.Domain.ValueObjects;
using PhraseService.Application.Ports;

namespace PhraseService.Application.UseCases.PublishPhrase
{
    public class PublishPhraseUseCase
    {
        private readonly IPhraseRepository _repository;

        public PublishPhraseUseCase(IPhraseRepository repository)
        {
            _repository = repository;
        }

        public async Task Execute(PublishPhraseCommand command)
        {
            Phrase phrase = new Phrase(command.Text, command.UserId, command.Style);

            await _repository.SaveAsync(phrase);
        }
    }
    
}