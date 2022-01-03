using System;
using System.Collections.Generic;
using System.Linq; // Для работы с массивами
using System.Text;
using System.Threading.Tasks;

namespace _27_Массивы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 110, 10, 4, 10, 111, 64, 77, 4, 42, 5};

            int min = arr.Min();

            Console.WriteLine(min); // мин. эл.
            Console.WriteLine(arr.Sum()); // сумма эл.

            // Сумма чётных эл.
            Console.WriteLine(arr.Where(i => i % 2 == 0).Sum()); // Лямбда выражения исп. для того, чтобы опр. чётный эл.

            int[] unique_arr = arr.Distinct().ToArray(); // Получение уникальных эл. из массива
            //Console.WriteLine(unique_arr);

            Console.WriteLine("____________________");

            // Сортировка массива
            int[] sorted_arr = arr.OrderBy(i => i).ToArray();
            Console.WriteLine(sorted_arr[0]);

            sorted_arr = arr.OrderByDescending(i => i).ToArray();
            Console.WriteLine(sorted_arr[0]);

            Console.WriteLine("____________________");

            // Сортировка массива через статические методы класса Array

            Console.WriteLine(arr[0]);
            Array.Sort(arr);
            Console.WriteLine(arr[0]);

            // Поиск в массиве

            Console.WriteLine("____________________");

            int[] chaosArr = { 111, 70, 10, 4, 64 };

            int less70 = Array.Find(chaosArr, i => i < 70); // Поиск 1-ого числа в массиве < 70

            Console.WriteLine(less70);

            Console.WriteLine("____________________");

            int[] arr2 = { 110, 10, 4, 10, 111, 64, 77, 4, 42, 5};

            int result = Array.FindIndex(arr2, i => i == 78); // Поиск индекса эл. по условию
            // Возращает -1, если эл. по условию не найден
            Console.WriteLine(result);

            Array.Reverse(arr2);

        }
    }
}
