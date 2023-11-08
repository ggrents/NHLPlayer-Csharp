using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHL_Player.Observer
{
    public interface IObserver
    {
        void Update(string trainingDetails);
    }
}
