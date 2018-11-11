using System;

namespace _02_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        bool aCheckSign = a > 0;
        bool bCheckSign = b > 0;
        bool cCheckSign = c > 0;
 
        if (aCheckSign ^ bCheckSign ^ cCheckSign)
        {
            Console.WriteLine("The sign will be \"+\"");
        }
        else
        {
            Console.WriteLine("The sign will be \"-\"");
        }

        }
    }
}
