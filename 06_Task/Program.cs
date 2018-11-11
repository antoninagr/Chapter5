using System;

namespace _06_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter coefficients a,b and c\n");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double d = (b * b) - 4 * a * c;
            if (d > 0)
            {
                double x1 = (-b - Math.Sqrt(d)) / 2 * a;
                double x2 = (-b + Math.Sqrt(d)) / 2 * a;
                Console.WriteLine("The equation has two roots x1= {0} and x2= {1}", x1, x2);
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("The equation has one root x= {0}", x);
            }
            else
            {
                Console.WriteLine("The equation has no real roots");
            }
        }
    }
}
