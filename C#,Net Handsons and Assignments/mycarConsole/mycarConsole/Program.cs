using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mycarConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            maruti objMaruti = new maruti();
            alto objAlto = new alto();
            string a = objMaruti.brake();
            int b = objMaruti.milage();
           // string s= objMaruti.model();
            int e = objAlto.GetPrice();
            //string q = objAlto.GetColor();
            Class3 objclass3 = new Class3();
           objclass3.pavan();

 string d=objAlto.model();
            string Model = Console.ReadLine();

           
            Console.WriteLine(d);

            //Console.WriteLine(st);
            Console.WriteLine(a);
            Console.WriteLine(e);
           // Console.WriteLine(s);
            Console.WriteLine(b);

            Console.ReadLine();
        }
    }
}
