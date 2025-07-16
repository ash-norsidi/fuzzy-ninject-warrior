using System.ComponentModel.DataAnnotations;

namespace FuzzyNinjectWarrior.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
    }
}
