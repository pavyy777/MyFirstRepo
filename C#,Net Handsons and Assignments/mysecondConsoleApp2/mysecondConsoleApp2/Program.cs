using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysecondConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            pulsar ObjPulsar = new pulsar();
            pulsarPrice ObjPulsarPrice = new pulsarPrice();
            ObjPulsar.GetColorDetails();
           ObjPulsar.GetModelDetails();
            ObjPulsarPrice.GetPriceDetails();
            Console.ReadLine();
        }
    }
}
