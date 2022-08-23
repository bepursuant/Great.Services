using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Great.Services
{
    class Program
    {
        
        static void Main(string[] args)
        {
            LogWrapper.Configure();

            TopShelfWrapper.Configure();

            Console.WriteLine("Test");
            Console.ReadKey();
        }
    }
}
