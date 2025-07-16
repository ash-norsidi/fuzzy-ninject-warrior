using FuzzyNinjectWarrior.Models;
using System.Collections.Generic;

namespace FuzzyNinjectWarrior.Repositories
{
    public interface IPlayerRepository
    {
        Player GetPlayerById(int id);
        IEnumerable<Enemy> GetAllEnemies();
        Enemy GetEnemyById(int id);
        void UpdatePlayer(Player player);
        void UpdateEnemy(Enemy enemy);
    }
}
