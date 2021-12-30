using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace listHandson
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numlist = new List<int>();
           
            for (int i =0; i < 4; i++)
            {
               
              int num= Convert.ToInt32(Console.ReadLine());
                numlist.Add(num);
            }

            Console.Write("\n numbers: ");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0}  ", (numlist[i]+2)*(5));
            }
            Console.ReadLine();
           
        }
            
            
    }
}
