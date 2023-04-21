namespace AppHero.Models
{
    public class School
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Hero> Heros { get; set; }

        public string? Localisation { get; set; }

        public School()
        {
        }
    }
}