using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractice
{
    class Program
    {
        string str;
        static void Main(string[] args)
        {

            Class1 objclass1 = new Class1();

            // string result = Convert.ToString(objclass1.GetPantColor());

            objclass1.GetPantColor();

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
