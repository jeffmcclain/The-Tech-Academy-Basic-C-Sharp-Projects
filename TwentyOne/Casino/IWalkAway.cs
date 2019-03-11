using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    interface IWalkAway // interface naming conventions require that all names start with an 'I'
    {
        void WalkAway(Player player);
    }
}
