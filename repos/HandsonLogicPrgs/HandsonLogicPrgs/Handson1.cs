using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonLogicPrgs
{
    class Handson1
    {


        public string CountString(string s)
        {
            return ;

            //Console.WriteLine("string:"+s);
            while (s.Length > 0)
            {
                Console.WriteLine(s[0] + "=");
                int count = 0;

                for (int i = 0; i < s.Length; i++)
                {

                    if (s[0] == s[i])
                    {
                        count++;
                    }


                }
                Console.WriteLine(count);
                s = s.Substring(s[0]);
            }
            Console.ReadLine();


        }
    }
}

