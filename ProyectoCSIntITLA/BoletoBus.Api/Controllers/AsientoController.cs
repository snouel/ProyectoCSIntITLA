using BoletoBus.Api.Model;
using BoletoBus.Api.Model.AsientoModel.AsientoModel;
using BoletoBus.Domain.Interfaces;
using BoletoBus.Infraestructure.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BoletoBus.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsientoController : ControllerBase
    {
        public readonly IAsientoRepository asientoRepository;

        public AsientoController(IAsientoRepository asientoRepository)
        {
           this.asientoRepository = asientoRepository;
        }

      
        // GET: api/<AsientoController>
        [HttpGet("GetAsientos")]
        public async Task<IActionResult> Get()
        {
            var asiento =  this.asientoRepository.GetAsientos();

            return Ok(asiento);

        }

        // GET: api/<AsientoController>
        [HttpGet("GetAsientosYBuses")]
        public async Task<IActionResult> GetAsientosYBuses()
        {
            var asientoAndBuses = this.asientoRepository.GetAsientosYBuses();

            return Ok(asientoAndBuses);

        }



        // GET api/<AsientoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AsientoController>
        [HttpPost]
        public void Post([FromBody] AsientoAddModel asientoAddModel)
        {
            var asiento = asientoAddModel.ConvertToEntityAsiento();
            this.asientoRepository.Save(asiento);
        }

        // PUT api/<AsientoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AsientoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
