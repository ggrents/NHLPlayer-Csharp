using NHL_Player.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL_Player.Observer
{
    public class Subscriber : IObserver
    {
        public HockeyPlayer _player { get; set; }
        public void Update(string trainingDetails)
        {
            Console.WriteLine($"{_player.Name} {_player.Surname} received notification: {trainingDetails}");
        }
    }
}
