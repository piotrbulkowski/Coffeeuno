using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shroomie.Fungi.Application.Queries.GetFungi;

namespace Shroomie.Api.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class FungiController : ControllerBase
{

    private readonly ILogger<FungiController> _logger;

    public FungiController(ILogger<FungiController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<FungiDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllFungi()
    {
        throw new NotImplementedException();
    }
}