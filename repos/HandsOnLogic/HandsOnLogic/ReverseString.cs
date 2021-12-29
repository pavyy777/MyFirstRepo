using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLogic
{
    class ReverseString
    {
        

            public   void Reverse()
            {
            string Input = "Pavan Upadhye";
            
            char[] charArray = Input.ToCharArray();

            Input.ToCharArray();
              
                string reversedString = String.Empty;

             
                for (int i = charArray.Length - 1; i > -1; i--)
                {

               
                    reversedString += charArray[i];
                }


            Console.WriteLine(reversedString.ToString()); 
           
            }
    }
}
