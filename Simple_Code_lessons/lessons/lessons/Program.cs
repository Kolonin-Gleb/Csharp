using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a;
            //
            //Console.WriteLine("Введите число для проверки на чёт/нечёт");
            //a = int.Parse(Console.ReadLine());
            //
            //Console.WriteLine(a);
            //
            //if (a % 2 == 0)
            //{
            //    Console.WriteLine("Число " + a + " чётное");
            //}
            //else
            //{
            //    Console.WriteLine("Число " + a + " нечётное");
            //}

            Console.WriteLine("Введите число от 1 до 3");
            int a = int.Parse(Console.ReadLine());

            switch(a)
            {
                case 1: Console.WriteLine("Число = 1");
                break;

                case 2: Console.WriteLine("Число = 2");
                break;

                case 3:
                Console.WriteLine("Число = 3");
                break;

                default:
                Console.WriteLine("Некорректный ввод");
                break;
            }
        }
    }
}
