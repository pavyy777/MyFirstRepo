using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseHandson
{
    class Program
    {
        static void Main(string[] args)
        {
             
    
               var course = new Course("xyz", 8, 800);
                var partCourse = new PartTimeCourse("Part Time Course\n", 6, 800);
                var onsiteCourse = new OnsiteCourse("Onsite Course\n", 12, 900);


                course.Print();
                partCourse.Print();
                onsiteCourse.Print();
            
            Console.WriteLine(  );
            Console.ReadLine();
             
            }
        }
    }

