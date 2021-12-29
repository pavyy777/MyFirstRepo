using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            int[] a = new int[100];
            Console.WriteLine("\n Read n number of value in an array it in reverse order");
            Console.WriteLine("......................................................");
            Console.WriteLine("input the num of elements to store in an array");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("input {0} num of elements in the array:\n",n);
            for (i = 0; i < 30; i++)
              {
                Console.WriteLine("element - {0} :",i);
                a[i] = Convert.ToInt32(Console.ReadLine());
                }
            Console.WriteLine("\n the valus store into thr array are:");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", a[i]);

            }
            Console.WriteLine("the values store into the array in reverse order");
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write("{0} ", a[i]);

            }
            Console.Write("\n\n");

        }
    }
}
