using NHL_Player.Models;
using NHL_Player.Adapter;
using NHL_Player.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL_Player
{
    public static class PlayerService 
    {
        public static HockeyPlayer AddPlayer(string name, string surname, string nationality, float height, float weight, int rating, int age, string position)
        {
            using (var dbContext = new HockeyDbContext())
            {

                var player = new HockeyPlayer
                {
                    Name = name,
                    Surname = surname,
                    Nationality = nationality,
                    Height = height,
                    Weight = weight,
                    Rating = rating,
                    Age = age,
                    Position = position,
                    Hand = false
                };
                dbContext.Players.Add(player);

                dbContext.SaveChanges();
                Console.WriteLine($"Player {name} created successfully!");
                return player;


            }
        }

        public static void DisplayPlayers()
        {
            using (var dbContext = new HockeyDbContext())
            {
                Console.WriteLine("List of Hockey Players:");

                var players = dbContext.Players.ToList();
                foreach (var player in players)
                {
                    IHockeyPlayerInfo adapter = new HockeyPlayerAdapter(player);
                    Console.WriteLine($"Id: {adapter.GetPlayerId()}, {adapter.GetFullName()}, " +
                        $"Nationality: {player.Nationality}, Rating: {player.Rating}, {adapter.GripHand()}");
                }
            }
        }

        public static List<HockeyPlayer> GetAllPlayers()
        {
            using (var dbContext = new HockeyDbContext())
            {
               

                var players = dbContext.Players.ToList();
                return players;
            }
        } 

        public static void UpdatePlayerHand(int id, bool handValue)
        {
            using (var dbContext = new HockeyDbContext())
            {
                var player = dbContext.Players.Find(id);

                if (player != null)
                {
                    player.Hand = handValue;

                    dbContext.SaveChanges();

                   
                }
                else
                {
                    Console.WriteLine($"Player with ID {id} not found!");
                }
            }
        }
    }
}
