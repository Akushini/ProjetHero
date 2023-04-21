using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppHero.Services
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class SchoolServices
    {
        // GET: api/<School>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<School>/5
        [HttpGet("{id},{name},{localisation}")]
        public string Get(int id, string? name, string? localisation)
        {
            return "value";
        }

        // POST api/<School>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<School>/5
        [HttpPut("{id}")]
        public void Put(int id, string? name, string? localisation, [FromBody] string value)
        {
        }

        // DELETE api/<School>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}