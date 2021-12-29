using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            // string file = @"P:\\csharp.txt";
            //Creating and Writting
            // using (StreamWriter writer = new StreamWriter(file))
            // {

            // writer.Write(DateTime.Now.ToString());
            //   Console.WriteLine(writer);
            //   Console.WriteLine("Successfully Added Current Date and Time");
            // }
            //Reading File
            //using (StreamReader reader = new StreamReader(file))
            // {
            //Console.Write("Reading Current Time : ");
            //Console.WriteLine(reader.ReadToEnd());
            //}
            // Console.ReadKey();


           string File =@"P:\\myFile\\c Sharp.txt";
           // FileStream objFilestream = new FileStream("P:\\myFile\\c Sharp.txt", FileMode.Create, FileAccess.ReadWrite);
          //  FileStream objFileS = new FileStream("P:\\myFile\\c Sharp.txt", FileMode.Open, FileAccess.Read);
            using (StreamWriter objStreamWriter = new StreamWriter(File))
            {



                objStreamWriter.Write(DateTime.Now.ToString());
                Console.WriteLine(objStreamWriter);
                Console.WriteLine("Saved Succesfully Current Date and time");
            }

           //FileStream objFileS = new FileStream("P:\\myFile\\c Sharp.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(File);
            
                Console.Write("Reading current Time: ");
                

                 Console.WriteLine(streamReader.ReadToEnd());


            


                




                Console.ReadKey();
         



    }
    }
}
