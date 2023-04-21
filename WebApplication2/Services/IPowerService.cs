using Microsoft.AspNetCore.Mvc;

namespace AppHero.Services
{
    public interface IPowersServices
    {
        [HttpGet]
        public IEnumerable<string> Get();
        [HttpGet("{id},{name},{heroName}")]
        public string Get(int id, string? name, string? heroName);

        [HttpPost]
        public void Post([FromBody] string value);
        [HttpPut("{id},{name},{heroName}")]
        public void Put(int id, string? name, string? heroName, [FromBody] string value);

        [HttpDelete("{id}")]
        public void Delete(int id);






    }
}