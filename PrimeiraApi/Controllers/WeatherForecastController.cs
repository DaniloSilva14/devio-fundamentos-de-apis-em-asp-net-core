using Microsoft.AspNetCore.Mvc;

namespace PrimeiraApi.Controllers
{
    [ApiController]
    //[Route("[controller]")
    [Route("api/minha-controller")]
    public class WeatherForecastController : ControllerBase
    {
        public WeatherForecastController()
        {
            
        }

        [HttpGet("teste")]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult Get2()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Get3()
        {
            return Ok();
        }

        //[HttpGet("{id}/dado/{id2}")]
        //public IActionResult Get4(int id, int id2)
        //{
        //    return Ok();
        //}

        [HttpGet("{id:int}/dado/{id2:int}")]
        public IActionResult Get5(int id, int id2)
        {
            return Ok();
        }
    }
}
