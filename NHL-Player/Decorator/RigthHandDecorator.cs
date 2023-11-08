using NHL_Player.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL_Player.Decorator
{
    public class RightHandDecorator : IHandDecorator
    {
        protected HockeyPlayer p;
        public RightHandDecorator(HockeyPlayer p) 
        {
            this.p = p;
        }

        public void SetHand()
        {
            p.Hand = true;
        }
    }

}
