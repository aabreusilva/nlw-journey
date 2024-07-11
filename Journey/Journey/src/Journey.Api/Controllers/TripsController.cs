using Journey.Application.UseCases.Trips.Register;
using Journey.Communication.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Journey.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripsController : ControllerBase
    {
        [HttpPost] //criando uma viajem.
        public IActionResult Register([FromBody] RequestRegisterTripJson request)
        {
            var useCase = new RegisterTripUseCase();
            
            useCase.Execute(request);
            
            return Created();//Função já apresentará cód. 201
        }
    }
}
