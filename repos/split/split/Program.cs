using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace split
{
    class Program
    {
        static void Main(string[] args)
        {

            //int counter;
            // string line;
           
            string path = @"P:\\myFile\\c Sharp\\networklog.txt";
            FileStream objfstream = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader objStreReader = new StreamReader(objfstream);
            // string s = objStreReader.ReadLine();
            ArrayList arr = new ArrayList();
          
            //List<int> list = new List<int>();

            arr.Add(objStreReader);
            Console.ReadLine();
            while (objStreReader.Peek() > 0)

            {

                string readmyline = objStreReader.ReadLine();


                string[] str = readmyline.Split(':');
                //string [] id = new string[5000];

                if (str.Length > 1)
                {
                    for(int i = 0; i < arr.Count; i++)
                    {
                        Console.WriteLine(arr[i]);
                    }
                   // str[1]
                       // Console.WriteLine( arr.Add(str[1]));
                       // Console.WriteLine();
                    
                }
                else
                {
                    Console.WriteLine("\n");
                }









            }

            //Console.Write("\n  ");
            Console.ReadKey();







        }
    }
    }

