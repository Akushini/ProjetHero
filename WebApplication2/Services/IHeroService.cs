using Microsoft.AspNetCore.Mvc;

namespace AppHero.Services
{
    public interface IHeroServices
    {
        [HttpGet]
        public IEnumerable<string> Get();

        [HttpGet("{id},{name},{power}")]
        public string Get(int id, string? name, string? power);

        [HttpPost]
        public void Post([FromBody] string value);

        [HttpPut("{id},{name},{power}")]
        public void Put(int id, string? name, string? power, [FromBody] string value);

        [HttpDelete("{id}")]
        public void Delete(int id);
    }
}