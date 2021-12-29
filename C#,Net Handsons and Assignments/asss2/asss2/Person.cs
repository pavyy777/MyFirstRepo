using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asss2
{
   public class Person
    {
     
        public  void PersonDetails()

        {
            
            Console.WriteLine();
            string fname = Console.ReadLine();
           
            Console.WriteLine();
            string lname = Console.ReadLine();
            if (fname.Length <= 10 && lname.Length <= 10)
            {

                Console.WriteLine(" Name: " + fname + "," + lname);
            }
            else
            {
                Console.WriteLine(" Your name length is too long ");
            }
            //Console.WriteLine(array);



        }
    }
}
