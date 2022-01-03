using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_algs_tasks
{
    class SwapNumbers
    {
        // Вывод: Поменять местами значения 2х целочисленных переменных можно, 
        // но это требует большое кол ар. операций.
        // Если есть возможность доб. 3 переменную, лучше сделать обмен значениями через неё.
        public static void Main(string[] args)
        {

            //Console.WriteLine("Введите значения переменных a и b");
            //Console.Write("a = ");

            //int x = int.Parse(Console.ReadLine());

            //Console.Write("b = ");

            //int y = int.Parse(Console.ReadLine());

            //SwapNumbers(ref x, ref y);
            //Console.Write($"Переменная a = {x}, переменная b = {y} ");
            //Console.ReadLine();

            int a = 10;
            int b = 15;

            Console.WriteLine($"Переменная a = {a}, переменная b = {b} ");

            (a, b) = (b, a);

            Console.WriteLine($"Переменная a = {a}, переменная b = {b} ");

            Console.ReadLine();
        }
        public static void Swap(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
    }
}
