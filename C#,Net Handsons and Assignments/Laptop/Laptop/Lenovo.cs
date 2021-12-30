using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop
{
    class Lenovo:laptopSpecs
    {
        public void NameDetails()
        {
            string Name = "Lenovo";
            Console.WriteLine("Name : {0} ", Name);

        }
        public void PriceDetails()
        {
            
            int Price = 28000;
            Console.WriteLine("Price : {0} ", Price);
        }
        public void HardiskDetails()
        {
            string Hard_Disk = "500 TB";
            Console.WriteLine("Hardisk : {0} ", Hard_Disk);
        }
    }
}
