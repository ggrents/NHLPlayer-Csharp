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

       
    }
}
