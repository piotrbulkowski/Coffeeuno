using Coffeeuno.Domain.Application.Queries.GetRoaster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Coffeeuno.Shared.Queries;

namespace Coffeeuno.Api.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class RoasterController : ControllerBase
{

    private readonly ILogger<RoasterController> _logger;

    public RoasterController(ILogger<RoasterController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public async Task<PagedList<object>> BrowseAsync()
    {
        throw new NotImplementedException();
    }
    [HttpGet]
    [ProducesResponseType(typeof(List<RoasterDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll()
    {
        throw new NotImplementedException();
    }
}