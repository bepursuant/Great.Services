using System;

namespace Great.Services
{
    class Program
    {

        static void Main(string[] args)
        {
            LogWrapper.Configure();
            ConfigWrapper.Configure();
            TopShelfWrapper.Configure();

            Console.WriteLine("Test");
            Console.ReadKey();
        }
    }
}
