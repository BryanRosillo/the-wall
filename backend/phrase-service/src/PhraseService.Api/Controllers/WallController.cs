using Microsoft.AspNetCore.Mvc;
using PhraseService.Application.UseCases.SeeTheWall;

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

        return Ok(phrases);
    }
}