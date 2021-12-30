using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
  namespace StackHandson
{
    class Person
    {
        public void PersonDetails()
        {
          Stack<string> Mystack = new Stack<string>();
            string name1=Console.ReadLine();
            string age1= Console.ReadLine();
            string name2 = Console.ReadLine();
            string age2 = Console.ReadLine();
            string name3= Console.ReadLine();
            string age3= Console.ReadLine();
            
            
            Mystack.Push(age3);
           Mystack.Push(name3);
            Mystack.Push(age2);
           Mystack.Push(name2);
            Mystack.Push(age1); 
            Mystack.Push(name1);
            
            foreach (var item in Mystack) {
                
                Console.Write(item + ",","\n");
                     }
           // Console.WriteLine(Mystack);
          
        }
    }
}
           
           
           