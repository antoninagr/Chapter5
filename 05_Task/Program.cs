using System;

namespace _05_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Spell a digit in Bulgarian.");
                      
            string spel;
            char ch = Console.ReadKey().KeyChar;

            switch (ch)
            {
                case '0': spel = "нула"; break;
                case '1': spel = "едно"; break;
                case '2': spel = "две"; break;
                case '3': spel = "три"; break;
                case '4': spel = "четири"; break;
                case '5': spel = "пет"; break;
                case '6': spel = "шест"; break;
                case '7': spel = "седем"; break;
                case '8': spel = "осем"; break;
                case '9': spel = "девет"; break;
                default: spel = "не е цифра"; break;
            }

            Console.WriteLine(" = " + spel);
        }

    }
}
