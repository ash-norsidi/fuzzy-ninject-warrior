using FuzzyNinjectWarrior.Models;
using FuzzyNinjectWarrior.Repositories;
using FuzzyNinjectWarrior.ApiClients;
using System;

namespace FuzzyNinjectWarrior.Services
{
    public class AdventureService : IAdventureService
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IGameLogger _gameLogger;

        public AdventureService(IPlayerRepository playerRepository, IGameLogger gameLogger)
        {
            _playerRepository = playerRepository;
            _gameLogger = gameLogger;
        }

        public Player GetCurrentPlayer()
        {
            // For demo, always return player with Id = 1
            return _playerRepository.GetPlayerById(1);
        }

        public AttackResultViewModel AttackEnemy(string enemyName, WeaponType weaponType)
        {
            var player = GetCurrentPlayer();
            var enemy = new Enemy { Name = enemyName, Health = 30, Level = 1 }; // Demo enemy

            int damage = CalculateDamage(player, weaponType);
            enemy.Health -= damage;

            string resultMsg = enemy.Health <= 0 ? $"{player.Name} defeated {enemy.Name}!" : $"{player.Name} hit {enemy.Name} for {damage} damage.";

            _gameLogger.LogEvent($"{player.Name} attacked {enemy.Name} with {weaponType} for {damage} damage.");

            return new AttackResultViewModel
            {
                Player = player,
                Enemy = enemy,
                ResultMessage = resultMsg
            };
        }

        private int CalculateDamage(Player player, WeaponType weaponType)
        {
            // Simple demo logic
            return 10 + (int)weaponType * 2 + player.Level;
        }
    }

    // ViewModel for the result view
    public class AttackResultViewModel
    {
        public Player Player { get; set; }
        public Enemy Enemy { get; set; }
        public string ResultMessage { get; set; }
    }
}
