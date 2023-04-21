using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppHero.Services
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class HeroServices //: ControllerBase
    {
        // GET: api/<Hero>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2", "value3" };
        }

        // GET api/<Hero>/5
        [HttpGet("{id},{name},{power}")]
        public string Get(int id, string? name, string? power)
        {
            return "value";
        }


        // POST api/<Hero>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Hero>/5
        [HttpPut("{id},{name},{power}")]
        public void Put(int id, string? name, string? power, [FromBody] string value)
        {
        }

        // DELETE api/<Hero>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}