using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL_Player.Strategy
{
    public class ShotStrategy : IPlayerStrategy
    {
        public void FollowTactic()
        {
            Console.WriteLine(" shot on goal from any point");
        }
    }
}
