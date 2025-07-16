using System;

namespace NinjectWarriorAdventure.Models
{
    public class GameEvent
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public string Description { get; set; }
        public int? PlayerId { get; set; }
        public int? EnemyId { get; set; }
    }
}
