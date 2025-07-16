using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NinjectWarriorAdventure.Models
{
    public class GameEvent
    {
        [Key]
        public int Id { get; set; }

        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        [Required]
        public string Description { get; set; }

        public int? PlayerId { get; set; }
        [ForeignKey("PlayerId")]
        public Player Player { get; set; }

        public int? EnemyId { get; set; }
        [ForeignKey("EnemyId")]
        public Enemy Enemy { get; set; }
    }
}
