using CleanArchitectureCQRS.Application.Commands;
using CleanArchitectureCQRS.Application.Events;
using CleanArchitectureCQRS.Domain.DTO.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureCQRS.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : Controller
    {

        private readonly IMediator mediator;

        public ClienteController(IMediator mediator)
        {

            this.mediator = mediator;
        }
        [HttpPost]

        public async Task<IActionResult> Post([FromBody] BaseEventCommand<ClienteRequest>.CriarCommand cmd)
        {
            await mediator.Send(cmd);
            return Ok(new
            {
                Message = "Criado com sucesso"
            });
        }
    }
}
