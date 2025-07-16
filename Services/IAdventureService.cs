using FuzzyNinjectWarrior.Models;

namespace FuzzyNinjectWarrior.Services
{
    public interface IAdventureService
    {
        string Attack(int playerId, int enemyId, WeaponType weapon);
    }
}
