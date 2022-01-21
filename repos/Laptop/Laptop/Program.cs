using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop
{
    class Program
    {
        static void Main(string[] args)
        {
            laptopSpecs objLaptop = new Laptop.laptopSpecs();
            Console.WriteLine("Asus Laptop Specifications Given Below");

            Asus objasus = new Asus();
            objasus.NameDetails();
            objasus.PriceDetails();
            objasus.ProcessorDetails1(); 
            objasus.RamDetails();
            objasus.HardiskDetails();
            Console.WriteLine("                                                   ");

           
            Console.WriteLine("Dell Laptop Specifications Given Below");
           
           Dell objdell = new Dell();
            objdell.DellDetails();
            objdell.PriceDetails();
            objdell.ProcessorDetails1();
            objdell.RamDetails();
            objdell.HardiskDetails();
          Console.WriteLine("                                                   ");

           
            Console.WriteLine("Hp Laptop Specifications Given Below");

             Hp objhp = new Hp();
            objhp.NameDetails();
            objhp.PriceDeatails();
            objhp.ProcessorDetails1();
            objhp.RamDetails();
            objhp.HardDiskDeatails();
            Console.WriteLine("                                                   ");
         
            
             Console.WriteLine("Lenovo Laptop Specifications Given Below");

            Lenovo objlenovo = new Lenovo();
            objlenovo.NameDetails();
            objlenovo.PriceDetails();
            objlenovo.ProcessorDetails2();
            objlenovo.RamDetails();
            objlenovo.HardiskDetails();
           
           Console.Read();

           
           
           
           
          
           
           
            
          
          
           
          
            
            
          
           
            

            
            
          
          
            
            
           
           

            
            
            

           

            
        }
    }
}
