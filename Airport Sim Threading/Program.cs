using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_Sim_Threading
{
    class Program
    {
        public List<Passager> pl = new List<Passager>();
        static void Main(string[] args)
        {
        }
        void Person()
        {
            Passager p = new Passager("bob",1, "Jamacia");
            pl.Add(p);

        }
    }
}
