using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novelvista
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "", reverse = "";

            int Length = 0;

            str = Console.ReadLine();
            string dup = str;
            Length = dup.Length - 1;



            while (Length >= 0)
            {
                reverse = reverse + dup[Length];
                Length--;
                Console.WriteLine(); 
                Console.ReadLine();
                if (reverse == str)
                {
                    Console.WriteLine("Palindrome");
                }
                else
                {
                    Console.WriteLine("Not Palindrome");
                }
                Console.ReadLine();
            }
        }   } }

