namespace AppHero.Models
{
    public class Power
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? HeroName { get; set; }

        public virtual ICollection<Hero> Heros { get; set; }



        public Power()
        {
        }
    }
}