using FuzzyNinjectWarrior.Models;
using FuzzyNinjectWarrior.Repositories;
using FuzzyNinjectWarrior.ApiClients;
using System;

namespace FuzzyNinjectWarrior.Services
{
    public class AdventureService : IAdventureService
    {
        private readonly IPlayerRepository _repo;
        private readonly IGameLogger _logger;

        public AdventureService(IPlayerRepository repo, IGameLogger logger)
        {
            _repo = repo;
            _logger = logger;
        }

        public string Attack(int playerId, int enemyId, WeaponType weapon)
        {
            var player = _repo.GetPlayerById(playerId);
            var enemy = _repo.GetEnemyById(enemyId);

            int weaponBonus = weapon switch
            {
                WeaponType.Sword => 5,
                WeaponType.Shuriken => 3,
                WeaponType.Bow => 4,
                _ => 0
            };

            int damage = player.Attack + weaponBonus;
            enemy.Health -= damage;

            string result;
            if (enemy.Health <= 0)
            {
                result = $"You defeated {enemy.Name} with your {weapon}!";
                enemy.Health = 0;
            }
            else
            {
                result = $"You hit {enemy.Name} for {damage} damage. Enemy health left: {enemy.Health}";
            }

            _repo.UpdateEnemy(enemy);
            _logger.LogEvent($"{player.Name} attacked {enemy.Name} with {weapon}: {result}");
            return result;
        }
    }
}
