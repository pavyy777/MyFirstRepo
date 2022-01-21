using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            int[] arr = new int[100];
            Console.Write("finding the sum of all elements in an array");
            Console.Write("............................................\n");
            Console.Write("enter a num of items to be add : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.Write("elements{0}: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                sum += arr[i];

            }
            
            Console.Write("sum of  elements in an array is :{0} ", sum);
            Console.Read();
        }
    }
}
