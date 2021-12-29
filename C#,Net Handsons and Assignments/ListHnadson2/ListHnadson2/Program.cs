using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListHnadson2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numlist = new List<int>();

            for (int i = 0; i < 4; i++)
            {
              
                int num = Convert.ToInt32(Console.ReadLine());
                numlist.Add(num);
            }

            Console.Write("\nnumbers: ");
            for (int i = 0; i < 4; i++)
            {
                
                Console.Write( "  " + (numlist[i])+""+(numlist[i]) + "" + (numlist[i]) + "" + (numlist[i]));
            }
            Console.ReadLine();
        }
    }
}
