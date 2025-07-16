using FuzzyNinjectWarrior.Models;

namespace FuzzyNinjectWarrior.ViewModels
{
    public class AttackResultViewModel
    {
        public Player Player { get; set; }
        public Enemy Enemy { get; set; }
        public string ResultMessage { get; set; }
    }
}
