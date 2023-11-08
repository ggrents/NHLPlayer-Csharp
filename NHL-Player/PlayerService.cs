using NHL_Player.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL_Player
{
    public static class PlayerService
    {
        public static void AddPlayer(string name, string surname, string nationality, float height, float weight, int rating, int age, string position)
        {
            using (var dbContext = new HockeyDbContext())
            {
                dbContext.Players.Add(new HockeyPlayer
                {
                    Name = name,
                    Surname = surname,
                    Nationality = nationality,
                    Height = height,
                    Weight = weight,
                    Rating = rating,
                    Age = age,
                    Position = position
                });

                dbContext.SaveChanges();

                Console.WriteLine($"Player {name} created successfully!");
            }
        }

        public static void DisplayPlayers()
        {
            using (var dbContext = HockeyDbContext.Instance)
            {
                Console.WriteLine("List of Hockey Players:");

                var players = dbContext.Players.ToList();
                foreach (var player in players)
                {
                    Console.WriteLine($"Name: {player.Name}, Surname: {player.Surname}, Nationality: {player.Nationality}, Rating: {player.Rating}");
                }
            }
        }
    }
}
