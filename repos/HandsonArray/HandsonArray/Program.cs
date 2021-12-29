using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HandsonArray
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string path = @"P:\\myFile\\c Sharp\\networklog.txt";
            FileStream objfstream = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader objStreReader = new StreamReader(objfstream);
            // string s = objStreReader.ReadLine();
            // Queue<string> queue1 = new Queue<string>();
            //Queue<string> queue2 = new Queue<string>();
          // int[] id = new int[15];
          //  string[] source = new string[15];
           // string[] destination = new string[15];
           // string[] date = new string[15];
            //string[] status = new string[15];
            //string[] network = new string[15];
            while (objStreReader.Peek() > 0)

            {

                string readmyline = objStreReader.ReadLine();


             

                string[] str = readmyline.Split(':');
                string[] st = readmyline.Select(x => int.Parse(x)).ToArray<int>();

                Console.WriteLine(st);
                Console.ReadLine();
            }
               // if (str.Length > 1)
               // {

                   // Console.Write("  "+str[1]);

                    //Console.WriteLine(id);
                   // Console.ReadLine();
               // }
                //else
               //   Console.WriteLine("\n");
               //
            }



            //Console.ReadLine();




        }
        
}

/*queue1.Enqueue(str[1]);
                queue2.Enqueue(str[2]);
 * 
 *  if (queue1.Count > 10)
                    {
                        Console.WriteLine(queue1);
                    }
 * 
 * if (readmyline.StartsWith("Date"))
{
    string date = str[1].Split(' ')[0];
    Console.Write("  " + date);
}*/