using System;


namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Class1 c = new Class1();
            int a = c.post;
            Console.WriteLine("{0},{1}",c.post,a);
            
        }
    }
}
