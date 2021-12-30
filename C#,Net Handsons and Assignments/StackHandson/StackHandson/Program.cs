using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackHandson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person obj = new Person();
            obj.PersonDetails();
            Person2 objp = new Person2();
            objp.Details();
            Console.ReadLine();
        }
    }
}
