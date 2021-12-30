using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace AssignmentSplit
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
            while (objStreReader.Peek() > 0)

            {
               
                string readmyline = objStreReader.ReadLine();


                string[] str = readmyline.Split(':');
                //string [] id = new string[5000];
               
                if (str.Length > 1)
                {
                    foreach (var item in str)
                    {
                        arr.Add(str[1]);
                        Console.Write();
                    }
                }
                else
                {
                    Console.WriteLine("\n");
                }


                  
                    
               

              
               

        }

                //Console.Write("\n  ");
                Console.ReadKey();







            }
        }// FileStream objfstream = new FileStream(path, FileMode.Open, FileAccess.Read);
            //StreamReader objStreReader = new StreamReader(objfstream);
            // objStreReader.WriteLine(path);
    } // string line1 = "Id=1";
                // string line2 = "Network=Jio";
               // string a = Convert.ToString(readmyline.StartsWith("id"));
               // string b = Convert.ToString(readmyline.EndsWith("Ntwrk"));
                //if (a==true)
                //{
                //    Console.WriteLine(a);
//}
               // else (readmyline.Contains("Network"))
              //  {
               //     Console.WriteLine(b);
              //  }
                //(str.Le/ 
/*  string line = "Id=1";
                string line1 = "Jio";
                if (line.StartsWith("1"))
                {
                    Console.WriteLine(readmyline);
                }
                else (line1.EndsWith("Jio"))
                        {
                    Console.WriteLine(readmyline);
                }
              
                */

