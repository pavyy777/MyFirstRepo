using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listhandson3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numberlist = chars(new List<string>(new string[]
            { "jhfcuahjhsf", "isuhagyagyg", "jxgagh", "jdhdh" }));
         
            foreach (var i in numberlist)
            {
                Console.Write(i.ToString() + " ");
            }
        }
        public static List<string> chars(List<string> str)
        {
            return str.Select(x => x.Replace("a", "")).ToList();
           


        } 
    } 
            
}
