using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Teacher : Person
    {
        private string subject;
        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }
        public void ShowAge1()
        {
            Console.WriteLine("My age is: {0} years old", age);
        }
    }


}
