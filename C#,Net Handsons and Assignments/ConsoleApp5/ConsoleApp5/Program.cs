using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    using System.IO;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
           // int counter;
           // string line;

            int i;
            string[] id = new string[1000];
            string path = @"P:\\myFile\\c Sharp\\networklog.txt";
            FileStream objfstream = new FileStream(path, FileMode.Open, FileAccess.Read);
            //StreamReader objStreReader = new StreamReader(objfstream);
            using (StreamReader objStreReader = new StreamReader(objfstream))
            {
                string s = "";
                int count = 0;
                Console.WriteLine(" Here is the content of the file mytest.txt : ");
                while ((s = objStreReader.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                    count++;
                }
                Console.WriteLine("");
            }
            Console.Write(" The number of lines in  the file {0} is : {1} \n\n", path);
           // string[] lines = File.ReadAllLines("P:\\myFile\\c Sharp\\networklog.txt").ToArray();
           // string[] id = new string[1000];
           //Console.WriteLine(lines);
            /*
            int s = objStreReader.ReadLine();
            int totalOfRecords = Convert.ToInt32(objStreReader.ReadLine());
            int[] id = new int[totalOfRecords];
            if (id==Id)
            {
                // string[] id = new string[14];
                //Console.ReadLine();
                Console.Write(id);

            }
           // string[] id = new string[1000];
                
                
                    Console.WriteLine(id);
                
                string[] source = new string[1000];
                string[] dest = new string[r];
                string[] date = new string[totalOfRecords];
                string[] status = new string[totalOfRecords];
                string[] network = new string[totalOfRecords];
            
            //  List<int> list = new List<int>();
            Console.WriteLine(source[15],dest[15],date[15],status[15]);
           // while (objStreReader.Peek() > 0)
            /*
           

                string readmyline = objStreReader.ReadLine();
                if (readmyline.StartsWith("Id"))
                {
                    // string[] id = new string[14];
                    Console.ReadLine();
                    Console.Write(id);
                    
                }
                else if (readmyline.StartsWith("Source"))
                    {
                   // add.string[] Source = new string[14];
                    Console.WriteLine();
                }
            // int read =Convert.ToInt32( objStreReader.ReadLine());

            // string[] str = readmyline.Split(':');

            // string[] id = new string[100];

            //if (str.Length > 1)
            //{
            //if(read.S)
            //int[] id = new int[read];
            // while(line=File.ReadLine()) !=null)

            //Console.WriteLine(str[1]);
            //for (i=1;i<14;i++)
            //
            //id[i]= Convert.ToInt32(Console.ReadLine());
            // }

            //Console.Write(id[str.Length]);
            //}
            //lse
            //{
            //   Console.WriteLine("\n");
            //}

            */







            }

            //Console.Write("\n  ");
            Console.ReadKey();







        }
    }
    
}
