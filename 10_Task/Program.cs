using System;

namespace _10_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            byte points;
            int total;

            Console.Write("Points (1 to 9) = ");
            points = byte.Parse(Console.ReadLine());

            switch (points)
            {
                case 1:
                case 2:
                case 3:
                    total = points * 10; break;
                case 4:
                case 5:
                case 6:
                    total = points * 100; break;
                case 7:
                case 8:
                case 9:
                    total = points * 1000; break;
                default:
                    total = 0; break;
            }
            if (total > 0)
            {
                Console.WriteLine("Total = {0}", total);
            }
            else
            {
                Console.WriteLine("Invalid number of points ({0})",
                                   points);
            }

        }
    }
}
