using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_Sim_Threading
{
    class Luggage
    {
        private int passagerNum;

        public int PassagerNum
        {
            get { return passagerNum; }
            set { passagerNum = value; }
        }
        private int luggagNum;

        public int LuggagNum
        {
            get { return luggagNum; }
            set { luggagNum = value; }
        }

        private int timeStamp;

        public int TimeStamp
        {
            get { return timeStamp; }
            set { timeStamp = value; }
        }

    }
}
