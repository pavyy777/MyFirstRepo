using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandellingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            House Myhouse = new House();
            //Console.WriteLine(Myhouse);
          Myhouse.CreatHouse();
            Myhouse.ReadHouseDetails();
            Student objstudent = new Student(25,"hgswygd");
            staff objstaff = new staff();
            objstaff.StaffStudent();
            //objstudent.Staff();
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
