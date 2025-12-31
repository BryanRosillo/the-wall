using Microsoft.AspNetCore.Mvc;
using PhraseService.Application.UseCases.SeeTheWall;

namespace PhraseService.Api.Controllers
{
    [ApiController]
    [Route("wall")]
    public class WallController : ControllerBase
    {
        private readonly SeeTheWallUseCase _useCase;

        public WallController(SeeTheWallUseCase useCase)
        {
            _useCase = useCase;
        }

        [HttpGet]
        public async Task<IActionResult> SeeTheWall()
        {
            var phrases = await _useCase.Execute();

            var response = phrases.Select(p => new WallItem(
                Text: p.Text,
                AuthorId: p.AuthorId,
                Font: p.Style.Font,
                FontSize: p.Style.FontSize,
                Color: p.Style.Color
            ));

            return Ok(response);
        }
    }
}