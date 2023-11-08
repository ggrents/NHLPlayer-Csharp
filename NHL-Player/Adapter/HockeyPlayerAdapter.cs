using NHL_Player.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL_Player.Adapter
{
    public class HockeyPlayerAdapter : IHockeyPlayerInfo
    {
        private readonly HockeyPlayer hockeyPlayer;

        public HockeyPlayerAdapter(HockeyPlayer hockeyPlayer)
        {
            this.hockeyPlayer = hockeyPlayer;
        }

        public int GetPlayerId()
        {
            return hockeyPlayer.Id;
        }

        public string GetFullName()
        {
            return $"{hockeyPlayer.Name} {hockeyPlayer.Surname}";
        }

        public string GripHand()
        {
            return hockeyPlayer.Hand ? "left-handed" : "right-handed";
        }
    }
}
