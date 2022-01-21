using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp3
{
    class student : person
    {
        public void ShowAge()
        {
            Console.WriteLine("My age is: {0} years old", age);
        }

    }
}
