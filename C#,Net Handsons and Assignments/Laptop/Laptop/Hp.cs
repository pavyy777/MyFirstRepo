using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop
{
    class Hp:laptopSpecs

    {
        public void NameDetails()
        {

            string Name = "Hp";
            Console.WriteLine("Name : {0} ", Name);


        }
        public void PriceDeatails()
        {

          
            int Price = 38000;
            Console.WriteLine("Price : {0} ", Price);


        }
        public void HardDiskDeatails()
        {

      
        string Hard_Disk = "512 SSD";
            Console.WriteLine("Hardisk : {0} ", Hard_Disk);

        }

    }
}
