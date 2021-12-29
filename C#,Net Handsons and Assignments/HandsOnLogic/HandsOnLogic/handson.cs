using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLogic
{
    class handson
    {
        public void OccCount()
        {
            string str = "aaabbbbb";
            Console.WriteLine("String: ", str);
             while (str.Length > 0)
            {
                Console.Write(str[0] + " = ");
                int count = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[0] == str[i])
                    {
                       count++;
                    }
                }
                Console.WriteLine(count);
                str = str.Replace(str[0].ToString(), string.Empty);
                Console.ReadLine();
           //
           }
            Console.ReadLine();
        }
    }
}
