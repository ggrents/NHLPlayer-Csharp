using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL_Player.Strategy
{
    public class DefenseStrategy : IPlayerStrategy
    {
        public void FollowTactic()
        {
            Console.WriteLine(" concentrate on defense");
        }
    }
}
