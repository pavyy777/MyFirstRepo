using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLogic
{
    public class RevString
    {
        public static void rev()
        {


           // string Input = "Pavan Upadhye";

            string[] Array = new string[] { "I ","am ","pavan " , " upadhye " };
{}
           // Console.WriteLine(Array);

            string reversedString = String.Empty;
           //Array[i].Split(' ');
           
            for (int i = Array.Length - 1; i > -1; i--)
            {
                

                reversedString += Array[i];
               
            }

            
            Console.WriteLine(reversedString.ToString());
        }
    }
}
