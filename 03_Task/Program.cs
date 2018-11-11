using System;

namespace _03_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter three integer numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("The biggest number is {0}", a);
                }
            }
            if (b > a)
            {
                if (b > c)
                {
                    Console.WriteLine("The biggest number is {0}", b);
                }
            }
            if (c > a)
            {
                if (c > b)
                {
                    Console.WriteLine("The biggest number is {0}", c);
                }
            }
        }
    }
}
