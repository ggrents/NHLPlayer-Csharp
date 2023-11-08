using NHL_Player.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL_Player.Factory
{
    public class Forward : HockeyPlayer
    {
        public Forward(string name, string surname, string nationality, float height, float weight, int rating, int age)
            : base(name, surname, nationality, height, weight, rating, age, "Forward")
        {
        }

      
    }

    public class Defense : HockeyPlayer
    {
        public Defense(string name, string surname, string nationality, float height, float weight, int rating, int age)
            : base(name, surname,  nationality, height, weight, rating, age, "Defense")
        {
        }

      
    }

    public class Goalie : HockeyPlayer
    {
        public Goalie(string name, string surname, string nationality, float height, float weight, int rating, int age)
            : base(name, surname, nationality, height, weight, rating, age, "Goalie")
        {
        }

    
    }

}
