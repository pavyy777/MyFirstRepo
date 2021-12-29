using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDueAmount
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDetails Pavan = new StudentDetails(10, "Pavan", "C#");
            StudentDetails Praveen = new StudentDetails(20, "Praveen", "ASP.NET");
            Tax tax = new Tax();
            tax.
            // tax.TotalFee();
           
            // Call Payment method
            Pavan.Payment(1100);
             Praveen.Payment(1800);

            // Print out student details
            Pavan.Print();

            Console.WriteLine("\n");

           // Console.ReadLine();
            Praveen.Print();
           // Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
    
}
