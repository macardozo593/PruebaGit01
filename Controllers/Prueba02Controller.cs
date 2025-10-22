using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PruebaGit01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Prueba02Controller : ControllerBase
    {
        // GET: api/<Prueba02Controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value_01", "value_02_MCC_Modifiado desde github" };
        }

        // GET api/<Prueba02Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Prueba02Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Prueba02Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Prueba02Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
