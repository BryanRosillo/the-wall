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
            if(command.Text is null)
                throw new ArgumentNullException(nameof(command.Text));

            if(command.UserId is null)
                throw new ArgumentNullException(nameof(command.UserId));
                
            if(command.Style is null)
                throw new ArgumentNullException(nameof(command.Style));

            Phrase phrase = new Phrase(command.Text, command.UserId, command.Style);

            await _repository.SaveAsync(phrase);
        }
    }
    
}