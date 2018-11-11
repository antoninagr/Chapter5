using System;

namespace _08_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter variable type (1 - int, 2 - double, 3 string): ");
            int intVar = Int32.Parse(Console.ReadLine());

            switch (intVar)
            {
                case 1:
                    {
                        Console.Write("Enter int variable: ");
                        intVar = Int32.Parse(Console.ReadLine());
                        intVar++;
                        Console.WriteLine("Int variable = {0}", intVar);
                        break;
                    }
                case 2:
                    {
                        Console.Write("Enter double variable: ");
                        double doubleVar = double.Parse(Console.ReadLine());
                        doubleVar++;
                        Console.WriteLine("Double variable = {0}", doubleVar);
                        break;
                    }
                case 3:
                    {
                        Console.Write("Enter string variable: ");
                        string stringVar = Console.ReadLine();
                        stringVar = stringVar + '*';
                        Console.WriteLine("String variable = {0}", stringVar);
                        break;
                    }
                default: Console.WriteLine("Wrong input"); break;
            }
        }
    }
}
