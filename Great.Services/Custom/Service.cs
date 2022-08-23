using System;

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
            LogWrapper.Log.Info("Settings are as follows: IsGreat={IsGreat}, ShoutOutsTo={ShoutOutsTo}", ConfigWrapper.Config.IsGreat, ConfigWrapper.Config.ShoutOutsTo);
        }

        public void Stop()
        {

        }

    }
}
