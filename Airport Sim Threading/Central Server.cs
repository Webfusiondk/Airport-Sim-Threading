using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Airport_Sim_Threading
{
    class Central_Server
    {
        static string CheckInpath = @"C\CheckInData.json";
        static string path = @"";

        void CreateFile()
        {
            //Tjekker om filen er der i forvejen hvis den ikke er der laver den en ny file
            if (!File.Exists(CheckInpath))
            {
                using (StreamWriter file = File.CreateText(CheckInpath))
                    file.Close();
            }
        }

        string ReadFromCheckIn()
        {
            return File.ReadAllText(CheckInpath);
        }


        public void PastCheckin(List<Luggage> luggagData)
        {
            CreateFile();
            string json = JsonConvert.SerializeObject(luggagData);
            File.WriteAllText(CheckInpath, json);
        }
    }
}
