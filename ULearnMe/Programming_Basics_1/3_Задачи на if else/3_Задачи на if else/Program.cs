using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Задачи_на_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите кол. рублей: ");
                int rubles = int.Parse(Console.ReadLine());
                HowManyRubles(rubles);
            }
        }
        static void HowManyRubles(int rubles)
        {
            int shortenRubles = rubles;
            shortenRubles %= 100;

            while (true)
            {
                if (shortenRubles >= 5 && shortenRubles <= 20)
                {
                    Console.WriteLine(rubles + " рублей");
                    break;
                }
                else
                {
                    shortenRubles %= 10;
                    if (shortenRubles == 1) // Особый случай для 1
                    {
                        Console.WriteLine("1 рубль");
                        break;
                    }
                    if (shortenRubles >= 2 && shortenRubles <= 4)
                    {
                        Console.WriteLine(rubles + " рубля");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(rubles + " рублей");
                        break;
                    }
                }
            }
        }
    }
}
