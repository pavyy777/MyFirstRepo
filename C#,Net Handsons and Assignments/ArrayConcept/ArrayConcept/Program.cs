using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConcept
{
    public class Program1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i;
            Console.WriteLine("\n Read and Print Elements in an Array:\n");
            Console.WriteLine("........................");
            Console.WriteLine("Input 10Elements In Array:");
            for (i = 0; i < 10; i++)
            {
                Console.Write("Element - {0} :", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements in Array Are:");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("is {0}  ", arr[i]);
                Console.Read();

            }
            Console.Write("\n");

            Console.Read();


        }
    }
}
