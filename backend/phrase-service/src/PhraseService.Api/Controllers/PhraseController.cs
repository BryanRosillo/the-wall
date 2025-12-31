using PhraseService.Application.UseCases.PublishPhrase;
using PhraseService.Domain.ValueObjects;
using Microsoft.AspNetCore.Mvc;

namespace PhraseService.Api.Controllers
{
    [ApiController]
    [Route("phrases")]
    public class PhraseController : ControllerBase
    {
        private readonly PublishPhraseUseCase _useCase;

        public PhraseController(PublishPhraseUseCase useCase)
        {
            _useCase = useCase;
        }

        [HttpPost]
        public async Task<IActionResult> Publish([FromBody] PublishPhraseRequest request)
        {
            var command = new PublishPhraseCommand
            {
                Text = request.Text,
                UserId = request.UserId,
                Style = new Style(request.Font, request.FontSize, request.Color)
            };

            await _useCase.Execute(command);

            return Ok();

        }
    }
}