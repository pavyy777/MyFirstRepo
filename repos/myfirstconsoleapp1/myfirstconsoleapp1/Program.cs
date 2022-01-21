using System;

namespace myfirstconsoleapp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = (int) 7.7;
            //float j = 3.2F;
            // char c = 'p';
            // int int x = c; 

            //Console.WriteLine("enter your name");

            //string name = Console.ReadLine();
            // Console.WriteLine("hi hello" +
            //double a = Math.Abs(-25.5);
            string hello = "pavan up";
            // Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToLower());
            //Console.WriteLine(hello.ToUpper());

            // Console.WriteLine(a);
            // int a=Math.Max(5, 2);
            //string name = Console.ReadLine();
           // string money = Console.ReadLine();
           // Console.WriteLine($"ur {name}.u will get{money}");
            Console.WriteLine(hello.IndexOf("n"));

            Console.WriteLine(hello.Substring(4));
            Console.ReadLine();

        }
    }
}
