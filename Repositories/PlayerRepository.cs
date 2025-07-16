using FuzzyNinjectWarrior.Models;
using System.Data.SQLite;
using System.Web.Hosting;

namespace FuzzyNinjectWarrior.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly string _connectionString;

        public PlayerRepository()
        {
            var dbPath = HostingEnvironment.MapPath("~/App_Data/FuzzyNinjectWarrior.db");
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString)); //$"Data Source={dbPath};Version=3;";
        }

        public Player GetPlayerById(int id)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("SELECT Id, Name, Level, Health, Weapon FROM Player WHERE Id = @id", connection);
                command.Parameters.AddWithValue("@id", id);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Player
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Level = reader.GetInt32(2),
                            Health = reader.GetInt32(3),
                            Weapon = (WeaponType)reader.GetInt32(4)
                        };
                    }
                }
            }
            // For demo, return a default player if not found
            return new Player { Id = id, Name = "Hero", Level = 1, Health = 100, Weapon = WeaponType.Sword };
        }
    }
}
