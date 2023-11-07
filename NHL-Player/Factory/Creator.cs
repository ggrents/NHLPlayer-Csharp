using NHL_Player.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL_Player.Factory
{
    public interface IHockeyPlayerFactory
    {
        HockeyPlayer CreatePlayer(string name, string nationality, float height, float weight, int rating, int age, string position);
    }
}
