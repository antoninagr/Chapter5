using System;

namespace _01_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b = int.Parse(Console.ReadLine());

            int c = new int();

            if (a > b)
            {
                c = b;
                b = a;
                a = c;

                Console.WriteLine();
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
        }
    }
}
