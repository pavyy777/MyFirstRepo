using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop
{
    class Asus:laptopSpecs
    {
        //public int Price = 30000;
        public void NameDetails()
        {
            
            string Name = "Asus";
            Console.WriteLine( "Name : {0} ", Name);
            


        }
        public  void PriceDetails() 
        { 
        
         //int Price = 30000;
       // Console.WriteLine("Price is :{} ",Price);
            // return ( n);
            int Price = 30000;
            Console.WriteLine("Price : {0} ", Price);

        }
        public void HardiskDetails()
        {
           string Hard_Disk = "1 TB";
            Console.WriteLine("Hardisk : {0} ", Hard_Disk);
        }
    }
}
