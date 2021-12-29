using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asss2
{
   public class Student:Person
    {
        public void StudentDetails()
        {
            Console.WriteLine();
            string id =Console.ReadLine();
            
            if (id.Length==7)
            {
                Console.WriteLine(" ID:" + id);
            }
            else
            {

                Console.WriteLine(" error");
            }

 }
        public void  Calc()
        {
            
            Console.WriteLine();
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int val2 = Convert.ToInt32(Console.ReadLine());
            float avg;
            if (val1 > 100 || val2 > 100 || val1 < 0 || val2 < 0)
            {
                Console.WriteLine(" error");
            }
            else
            {
                avg = (val1 + val2) / 2;
                if (avg > 100)
                {
                    Console.WriteLine(" error");
                }
                else if (avg >= 90 && avg <= 100)
                {
                    Console.WriteLine(" O");
                }
                else if (avg >= 80 && avg <= 90)
                {
                    Console.WriteLine(" E");
                }
                else if (avg >= 70 && avg <= 80)
                {
                    Console.WriteLine(" A");
                }
                else if (avg >= 55 && avg <= 70)
                {
                    Console.WriteLine(" P");
                }
                else if (avg >= 40 && avg <= 55)
                {
                    Console.WriteLine(" D");
                }
                else 
                        
                    Console.WriteLine(" T");
                
            }
            Console.WriteLine();
         
            
            

         

           
            
            
        }

    }
}
