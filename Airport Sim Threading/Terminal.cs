using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_Sim_Threading
{
    class Terminal
    {
        int gateNum;

        string GateOpen()
        {
            return "Gate " + gateNum + " er nu åben, vær venlig at begynde at borde flyet";
        }


        string GateClose()
        {
            return "Gate " + gateNum + " er nu lukket og det er ikke muligt at bord flyet længer";
        }
    }
}
