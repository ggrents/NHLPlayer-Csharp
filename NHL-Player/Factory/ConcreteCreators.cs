using NHL_Player.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL_Player.Factory
{
    public class ForwardFactory : IHockeyPlayerFactory
    {
        public HockeyPlayer CreatePlayer(string name, string surname , string nationality, float height, float weight, int rating, int age)
        {
            return new Forward(name, surname , nationality, height, weight, rating, age);
        }
    }

    public class DefenseFactory : IHockeyPlayerFactory
    {
        public HockeyPlayer CreatePlayer(string name, string surname, string nationality, float height, float weight, int rating, int age)
        {
            return new Defense(name, surname , nationality, height, weight, rating, age);
        }
    }

    public class GoalieFactory : IHockeyPlayerFactory
    {
        public HockeyPlayer CreatePlayer(string name, string surname, string nationality, float height, float weight, int rating, int age)
        {
            return new Goalie(name, surname, nationality, height, weight, rating, age);
        }
    }
}
