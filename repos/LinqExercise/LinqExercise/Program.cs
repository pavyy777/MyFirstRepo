using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "jd65w87w8985@$$$$%^7g";
         var st=str.GroupBy(j=>j).OrderByDescending(c=>c.Count()).First().Key;
            Console.WriteLine(st);
            var rnd = new Random();
            var arr = new[] { 1, 2, 3, 4 };
            var shufle = arr.OrderBy(s => rnd.Next());
            foreach (var d in shufle)
            {
                Console.WriteLine(d);
                Console.ReadLine();
            }
           

            Console.ReadLine();
            var S = new List<string> { "afgym", "jhfduh", "auhffm", "am" };
            var modify = S.OrderBy(s => s).FirstOrDefault(s => s.Contains("u"));
            foreach (var i in modify)
            {
                Console.WriteLine($"{modify}");
                Console.ReadLine();
            }
            List<int> n = new List<int> { 1, 2, 5,15,25,45,24,32,29 };
            
            var sqr = n.Where(c => c * c <500);
            foreach (var d in sqr)
            {
                Console.Write(d);
                Console.ReadLine();
            }
        
        List<int> Numbers = new List<int> { 25, 5, 54, 32, 55, 35, 87, 99, 46, 22, 34 };
        var SelectedNumbers = Numbers.Where(x => x < 100).Where(x => x > 54);
            //int count = 0;
            foreach(var item in SelectedNumbers)
            {
                Console.WriteLine(item);
                //count++;
                Console.ReadLine();
            }
           List<string> Animals = new List<string> { "cow", "zebra", "tiger", "lion" };
            var CapaAnimals = Animals.Where(y => y.Length <= 3).Select(s => s.ToUpper());
            foreach(var s in CapaAnimals)
            {
                Console.WriteLine(s);
                Console.ReadLine();
            }
            List<string> SE = new List<string> { "afgym", "jhfduh", "auhffm", "am" };
            var StartEnd = SE.Where(f => f.StartsWith("a")).Where(a => a.EndsWith("m"));
            foreach(var se in StartEnd)
            {
                Console.WriteLine(se);
                Console.ReadLine();
            }
            List<int> nums = new List<int> {15,25,24,36,14,85,67,66,99};
            var dscending = nums.OrderByDescending(c => c).Take(9);
            foreach(var d in dscending)
            {
                int s = d;
                Console.WriteLine(d);
                Console.ReadLine();

            }
            



        }

    }
}

