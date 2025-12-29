using PhraseService.Domain.Entities;
using PhraseService.Domain.ValueObjects;

namespace PhraseService.Application.UseCases.PublishPhrase
{
    public class PublishPhraseCommand
    {
        public string? Text {get; init;}
        public string? UserId {get; init;}
        public Style? Style {get; init;}

    }
    
}