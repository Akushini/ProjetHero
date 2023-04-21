using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppHero.Services
{
    //[Route("api/[controller]")]
    // [ApiController]
    public class PowersServices
    {
        // GET: api/<Powers>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Powers>/5
        [HttpGet("{id},{name},{heroName}")]
        public string Get(int id, string? name, string? heroName)
        {
            return "value";
        }

        // POST api/<Powers>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Powers>/5
        [HttpPut("{id},{name},{heroName}")]
        public void Put(int id, string? name, string? heroName, [FromBody] string value)
        {
        }

        // DELETE api/<Powers>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}