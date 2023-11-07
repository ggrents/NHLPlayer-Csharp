using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL_Player.Models
{
    public class HockeyPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public int Rating { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }

        public HockeyPlayer(string name, string nationality, float height, float weight, int rating, int age, string position)
        {
            this.Name = name;
            this.Nationality = nationality;
            this.Height = height;   
            this.Weight = weight;   
            this.Rating = rating;
            this.Age = age;
            this.Position = position;
        }

        public static List<HockeyPlayer> Players { get; } = new List<HockeyPlayer>();

        public static void CreatePlayer(string name, string nationality, float height, float weight, int rating, int age)
        {
            var newPlayer = new HockeyPlayer
            {
                Name = name,
                Nationality = nationality,
                Height = height,
                Weight = weight,
                Rating = rating,
                Age = age
            };

            Players.Add(newPlayer);
            Console.WriteLine($"Player {name} created successfully!");
        }

        public static void DisplayPlayers()
        {
            Console.WriteLine("List of Hockey Players:");

            foreach (var player in Players)
            {
                Console.WriteLine($"Name: {player.Name}, Nationality: {player.Nationality}, Rating: {player.Rating}");
            }
        }
    }



}
