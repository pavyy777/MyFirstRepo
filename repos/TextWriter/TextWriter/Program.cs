using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextWriter
{
    class Program
    {
        static void Main(string[] args)
        {

            string file = @"C:\MyFile\New folder.txt";
            using (BinaryWriter writer = new BinaryWriter(File.Open(file, FileMode.Create)))
            {
                writer.Write( DateTime.Now.ToString());
                Console.WriteLine("Time is:", writer);
            }
              BinaryReader reader = new BinaryReader(File.Open(file, FileMode.Open,FileAccess.Read));
             string str = reader.ReadString();
             Console.WriteLine(str);


           

            Console.ReadKey();
        }
    }
}
