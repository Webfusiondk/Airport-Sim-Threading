using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_Sim_Threading
{
    class DropOff
    {
        public List<Luggage> luggagData = new List<Luggage>();
        Random r = new Random();
        int dropOffNum;
        public int dropOffOpen;
        public string CheckInOpen()
        {
            dropOffOpen = r.Next(1, 3);
            return "Skrake " + dropOffOpen + " Er nu åben til check in";
        }

        public string CheckIn()
        {
            
            string currentTime = string.Format("{0:HH:mm:ss}", DateTime.Now);
            int passagerNum = +1;
            int luggagNum = +1;
            int timeStamp = Convert.ToInt32(currentTime);
            Central_Server CS = new Central_Server();
            Luggage luggage = new Luggage();
            luggage.PassagerNum = passagerNum;
            luggage.LuggagNum = luggagNum;
            luggage.TimeStamp = timeStamp;
            luggagData.Add(luggage);
            CS.PastCheckin(luggagData);
            CheckInClosed();
            return "Tak fordi du har tjekket ind";
        }

        public string CheckInClosed()
        {
            return "Skrake " + dropOffOpen + " Er nu lukket for check in";
        }
    }
}
