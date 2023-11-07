using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL_Player.Models
{
    public class HockeyDbContext : DbContext
    {
        public DbSet<HockeyPlayer> Players { get; set; }

        private static readonly Lazy<HockeyDbContext> instance = new Lazy<HockeyDbContext>(() => new HockeyDbContext());

        public static HockeyDbContext Instance => instance.Value;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // подключение к дб
            optionsBuilder.UseNpgsql("Host=localhost;Database=NHL;Username=postgres;Password=2996");
        }
    }

    public sealed class DatabaseConnection
    {
        private DatabaseConnection() { }

        private static readonly Lazy<DatabaseConnection> instance = new Lazy<DatabaseConnection>(() => new DatabaseConnection());

        public static DatabaseConnection Instance => instance.Value;

        public void CreatePlayer(string name, string nationality, float height, float weight, int rating, int age)
        {
            using (var dbContext = HockeyDbContext.Instance)
            {
                dbContext.Players.Add(new HockeyPlayer
                {
                    Name = name,
                    Nationality = nationality,
                    Height = height,
                    Weight = weight,
                    Rating = rating,
                    Age = age
                });

                dbContext.SaveChanges();

                Console.WriteLine($"Player {name} created successfully!");
            }
        }

        public void DisplayPlayers()
        {
            using (var dbContext = HockeyDbContext.Instance)
            {
                Console.WriteLine("List of Hockey Players:");

                var players = dbContext.Players.ToList();
                foreach (var player in players)
                {
                    Console.WriteLine($"Name: {player.Name}, Nationality: {player.Nationality}, Rating: {player.Rating}");
                }
            }
        }
    }
}
