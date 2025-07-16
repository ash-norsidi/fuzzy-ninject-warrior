using FuzzyNinjectWarrior.Models;

namespace FuzzyNinjectWarrior.Services
{
    public interface IAdventureService
    {
        Player GetCurrentPlayer();
        AttackResultViewModel AttackEnemy(string enemyName, WeaponType weaponType);
    }
}
