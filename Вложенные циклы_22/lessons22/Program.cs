using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вложенные циклы
            while (true)
            {
                const int LEVEL = 5;
                for (int i = 0; i <= LEVEL; i++) // рост уровня
                {
                    for (int j = 0; j <= i; j++) // вывод # до момента достижения уровня
                    {
                        Console.Write("#");
                    }
                    Console.Write("\n");
                }

                for (int i = LEVEL; 0 <= i; i--) // снижение уровня
                {
                    for (int j = 0; j <= i; j++) // вывод # до момента достижения уровня
                    {
                        Console.Write("#");
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}
