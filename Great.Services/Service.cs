using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Great.Services
{
    class Service
    {
        public static string ServiceName = "GreatService";
        public static string DisplayName = "Great Services for All";
        public static string Description = "Nothing to describe really...";

        public void Start()
        {
            Console.WriteLine("Start");
            LogWrapper.Log.Info("Test");
        }

        public void Stop()
        {

        }

    }
}
