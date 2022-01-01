using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Массивы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// тип_переменной[] название_массива;
            //int[] myArray; // Указатель
            //
            //// Динамическое выделение памяти под массив
            //// Массивы в С# по умолчанию заполнены 0
            //myArray = new int[5]; // Создание массива на 5 элементов
            //// Чистить данные не надо. Это будет сделано автоматически.
            //
            //// Изменение значения по индексу
            //myArray[0] = 1;
            //
            //// Перебор всех эл. массива
            //foreach (int i in myArray)
            //{
            //    Console.WriteLine(i);
            //}
            //
            //Console.WriteLine("________");
            //
            //// Изменение размера массива = его пересоздание
            //myArray = new int[10];
            //
            //// Перебор всех эл. массива
            //foreach (int i in myArray)
            //{
            //    Console.WriteLine(i);
            //}
            //
            //Console.WriteLine("________");
            //
            //// Инициализация массива числами в диапозоне
            //myArray = Enumerable.Range(1, 5).ToArray(); // Идёт пересоздание массива, т.к. диапозон < длины массива
            //
            //// Перебор всех эл. массива
            //foreach (int i in myArray)
            //{
            //    Console.WriteLine(i);
            //}

            /* Инициализация массива с клавиатуры + f-строки */

            Console.WriteLine("Инициализация массива с клавиатуры \n");

            Console.WriteLine("Введите размер массива");
            int arr_size = int.Parse(Console.ReadLine());

            int[] arr = new int[arr_size];

            for (int i = 0; i < arr_size; i++)
            {
                Console.WriteLine($"Введите {i} элемент массива");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ваш массив: ");
            for (int i = 0; i < arr_size; i++)
            {
                Console.Write(arr[i] + "\t");
            }

            Console.ReadLine();
        }
    }
}
