using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp3
{
   public class teacher:person
    {
       
        private string subject;
        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }
        
             void ShowAge(int n)

        {
                int age = n;
            Console.WriteLine("My age is: {0} years old", age);
        }
        
    }
}
