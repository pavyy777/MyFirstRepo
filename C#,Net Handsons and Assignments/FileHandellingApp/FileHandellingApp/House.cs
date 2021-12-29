using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandellingApp
{
    class House
    {
        public void CreatHouse()
        {
            //file creation 
            // string path, FileMode mode, FileAccess access
            FileStream ObjFileStream = new FileStream("P:\\myFile\\New folder.txt", FileMode.Create, FileAccess.Write);
            //file write operation
            StreamWriter sw = new StreamWriter(ObjFileStream);
            sw.WriteLine("WelCome To My House");
            Console.Write("Enter my house name:");
            String Housename = Console.ReadLine();
            Console.Write("Enter my house adress:");
            String adress = Console.ReadLine();
            Console.Write("Enter my phone num:");
            int phone =Convert.ToInt32( Console.ReadLine());
            sw.WriteLine("House name:" + Housename);
            sw.WriteLine("house adress::" + adress);
            sw.WriteLine("phone num:" + phone);

            sw.Close();
            ObjFileStream.Close();
            Console.WriteLine("saved succesfully");
        }
        public void ReadHouseDetails()
        {
        }
    }
}
