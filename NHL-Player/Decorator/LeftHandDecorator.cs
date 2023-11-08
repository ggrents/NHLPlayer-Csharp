using NHL_Player.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL_Player.Decorator
{
    public class LeftHandDecorator : IHandDecorator
    {
        protected HockeyPlayer p;
        public LeftHandDecorator(HockeyPlayer p) 
        {
            this.p = p;
        }

        public void SetHand()
        {
            p.Hand = false;
        }
    }
       
}
