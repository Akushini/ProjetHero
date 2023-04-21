using System.Xml.Linq;

namespace AppHero.Models
{
    public class Hero
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Power { get; set; }

        public virtual ICollection<Power> Powers { get; set; }
        public virtual School Schools { get; set; }

        public Hero()
        {
        }




    }
}