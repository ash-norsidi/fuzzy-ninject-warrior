using FuzzyNinjectWarrior.Models;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Configuration;

namespace FuzzyNinjectWarrior.Repositories
{
    // NOTE: In production, use Entity Framework or Dapper for DB access.
    public class PlayerRepository : IPlayerRepository
    {
        private readonly string _connectionString;

        public PlayerRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public Player GetPlayerById(int id)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT Id, Name, Health, Attack FROM Player WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Player
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Health = reader.GetInt32(2),
                            Attack = reader.GetInt32(3)
                        };
                    }
                }
            }
            return null;
        }

        public IEnumerable<Enemy> GetAllEnemies()
        {
            var enemies = new List<Enemy>();
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT Id, Name, Health, Attack FROM Enemy", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        enemies.Add(new Enemy
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Health = reader.GetInt32(2),
                            Attack = reader.GetInt32(3)
                        });
                    }
                }
            }
            return enemies;
        }

        public Enemy GetEnemyById(int id)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("SELECT Id, Name, Health, Attack FROM Enemy WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Enemy
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Health = reader.GetInt32(2),
                            Attack = reader.GetInt32(3)
                        };
                    }
                }
            }
            return null;
        }

        public void UpdatePlayer(Player player)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand(
                    "UPDATE Player SET Health = @health, Attack = @attack WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@health", player.Health);
                cmd.Parameters.AddWithValue("@attack", player.Attack);
                cmd.Parameters.AddWithValue("@id", player.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateEnemy(Enemy enemy)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand(
                    "UPDATE Enemy SET Health = @health, Attack = @attack WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@health", enemy.Health);
                cmd.Parameters.AddWithValue("@attack", enemy.Attack);
                cmd.Parameters.AddWithValue("@id", enemy.Id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
