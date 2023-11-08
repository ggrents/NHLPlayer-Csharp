using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHL_Player;

namespace NHL_Player.Adapter
{
    public interface IHockeyPlayerInfo
    {
        int GetPlayerId();
        string GetFullName();
        string GripHand();
        
    }
}
