using System;

namespace ns
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] myArray = { 2, 10, 5, 6, 77, 89, 101 };

            //// Вывод последнего эл. массива
            //Console.WriteLine(myArray[myArray.Length - 1]);
            //// Сахар. Для его использование проект - .Net Core

            //Console.WriteLine(myArray[^1]); // Нумерация с конца массива начинается с 1


            //// Принцип работы диапозонов
            //// Извлечение эл. из массива по диапозону

            //int[] arr = myArray[1..4]; // начало диапозона..конец не вкл

            //int[] myArray = { 2, 10, 5, 6, 77, 89, 101 };

            //Index myIndex = ^2; // Индекс - это тоже тип данных (структура)
            //// наличие ^ - взятие эл. с конца
            //Console.WriteLine("Вывод данных из массива по индексу");
            //Console.WriteLine(myArray[myIndex]);

            //// Вывод полей структуры Index
            //Console.WriteLine("Информация об использованном индексе");
            //Console.WriteLine($"value {myIndex.Value} isFromEnd {myIndex.IsFromEnd}");


            //// Доп. способ создания индексов

            //int[] myArray = { 2, 10, 5, 6, 77, 89, 101 };

            //Index index = new Index(3, true); // Перегрузка конструктора Index

            //Console.WriteLine(myArray[index]);

            //// Range - диапозон - тоже явл. структурой

            //Range range = 1..4; // Эквивалент Range range = new Range(1, 4)

            //Console.WriteLine(myArray[range]);

            // Использование индексов и диапозонов к строке (ведь она тоже массив, только символов)
            string str = "Hello World!!! =)";

            Console.WriteLine(str);

        }
    }
}
