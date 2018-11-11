using System;

namespace _11_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 0 and 999: ");
            short number = Convert.ToInt16(Console.ReadLine());

            byte hundreds = (byte)(number / 100 | 0);
            byte tensAndOnes;

            if (number > 99) tensAndOnes = (byte)(number % 100);
            else tensAndOnes = (byte)(number * 1);

            byte ones = (byte)(number % 10);

            switch (hundreds)
            {
                case 1: Console.Write("сто "); break;
                case 2: Console.Write("двеста "); break;
                case 3: Console.Write("триста "); break;
                case 4: Console.Write("четиристотин "); break;
                case 5: Console.Write("петстотин "); break;
                case 6: Console.Write("шестстотин "); break;
                case 7: Console.Write("седемстотин "); break;
                case 8: Console.Write("осемстотин "); break;
                case 9: Console.Write("деветстотин "); break;
            }



            if (tensAndOnes >= 20 && tensAndOnes < 30) Console.Write("двадесет ");
            else if (tensAndOnes >= 30 && tensAndOnes < 40) Console.Write("тридесет ");
            else if (tensAndOnes >= 40 && tensAndOnes < 50) Console.Write("четиридесет ");
            else if (tensAndOnes >= 50 && tensAndOnes < 60) Console.Write("петдесет ");
            else if (tensAndOnes >= 60 && tensAndOnes < 70) Console.Write("шестдесет ");
            else if (tensAndOnes >= 70 && tensAndOnes < 80) Console.Write("седемдесет ");
            else if (tensAndOnes >= 80 && tensAndOnes < 90) Console.Write("осемдесет ");
            else if (tensAndOnes >= 90 && tensAndOnes < 100) Console.Write("деветдесет ");

            switch (tensAndOnes)
            {
                case 1: Console.Write("едно"); break;
                case 2: Console.Write("две"); break;
                case 3: Console.Write("три"); break;
                case 4: Console.Write("четири"); break;
                case 5: Console.Write("пет"); break;
                case 6: Console.Write("шест"); break;
                case 7: Console.Write("седем"); break;
                case 8: Console.Write("осем"); break;
                case 9: Console.Write("девет"); break;
                case 10: Console.Write("десет"); break;
                case 11: Console.Write("единадесет"); break;
                case 12: Console.Write("дванадесет"); break;
                case 13: Console.Write("тринадесет"); break;
                case 14: Console.Write("четиринадесет"); break;
                case 15: Console.Write("петнадесет"); break;
                case 16: Console.Write("шестнадесет"); break;
                case 17: Console.Write("седемнадесет"); break;
                case 18: Console.Write("осемнадесет"); break;
                case 19: Console.Write("деветнадесет"); break;
            }
            if (tensAndOnes > 20)
            {
                switch (ones)
                {
                    case 1: Console.Write("и едно"); break;
                    case 2: Console.Write("и две"); break;
                    case 3: Console.Write("и три"); break;
                    case 4: Console.Write("и четири"); break;
                    case 5: Console.Write("и пет"); break;
                    case 6: Console.Write("и шест"); break;
                    case 7: Console.Write("и седем"); break;
                    case 8: Console.Write("и осем"); break;
                    case 9: Console.Write("и девет"); break;
                }
            }
            if (number == 0) Console.Write("нула");
            Console.ReadLine();
        }
    }
}
