using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_Sim_Threading
{
    class Passager
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int passagerId;

        public int PassagerId
        {
            get { return passagerId; }
            set { passagerId = value; }
        }
        private string flight;

        public string Flight
        {
            get { return flight; }
            set { flight = value; }
        }
        public Passager(string name, int passagerid, string flight)
        {
            Name = name;
            PassagerId = passagerid;
            Flight = flight;
        }

    }
}
