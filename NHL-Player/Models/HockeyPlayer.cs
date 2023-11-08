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
        public string Surname { get; set; }
        public string Nationality { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public int Rating { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }

        public HockeyPlayer()
        {
            
        }

        public HockeyPlayer(string name, string surname, string nationality, float height, float weight, int rating, int age, string position)
        {
            this.Name = name;
            this.Surname = surname;
            this.Nationality = nationality;
            this.Height = height;
            this.Weight = weight;
            this.Rating = rating;
            this.Age = age;
            this.Position = position;
        }

      
    }



}
