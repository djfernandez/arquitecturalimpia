using CleanArchitecture.Application.Features.Maestras.Queries;
using CleanArchitecture.Domain;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CleanArchitecture.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class MaestraController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MaestraController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name ="ListadoMaestras")]
        [Authorize]
        [ProducesResponseType(typeof(IEnumerable<Maestra>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Maestra>>> GetMaestrasAll()
        {
            var query = new GetAllMaestras();
            return Ok(await _mediator.Send(query));
        }

    }
}
