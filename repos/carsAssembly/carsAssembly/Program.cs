using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carsAssembly
{
    class Program
    {
        static void Main(string[] args)
        {
            AssemblyLine.Succesrate(6);
          
            AssemblyLine.RatePerHour(6);
           
            AssemblyLine.workingItemsPerMinute(6);
            Console.ReadLine();

        }
    }
}
