using NinjectWarriorAdventure.Models;
using System.Collections.Generic;

namespace NinjectWarriorAdventure.Repositories
{
    public interface IPlayerRepository
    {
        Player GetPlayer(int id);
        IEnumerable<Player> GetAllPlayers();
        void AddPlayer(Player player);
        void UpdatePlayer(Player player);
        void DeletePlayer(int id);
    }
}
