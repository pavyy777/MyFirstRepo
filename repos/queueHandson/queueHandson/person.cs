using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queueHandson
{
    class person
    {
       
            public void Details()
            {
                Queue<string> Myqueue = new Queue<string>();
                string name1 = Console.ReadLine();
                string age1 = Console.ReadLine();
                string name2 = Console.ReadLine();
                string age2 = Console.ReadLine();
                string name3 = Console.ReadLine();
                string age3 = Console.ReadLine();
                Myqueue.Enqueue(name1);
                Myqueue.Enqueue(age1);
                Myqueue.Enqueue(name2);
                Myqueue.Enqueue(age2);
                Myqueue.Enqueue(name3);
                Myqueue.Enqueue(age3);
                foreach (var item in Myqueue)
                {

                    Console.Write(item + ",", "\n");
                }
            }
        }
    }


