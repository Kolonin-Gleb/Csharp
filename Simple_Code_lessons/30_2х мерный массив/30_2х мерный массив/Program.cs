using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_2х_мерный_массив
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Способы инициализации 2х мерных массивов
            // тип данных[,] имя массива
            //int[,] arr = { {1, 3, 5, 7, 9},{0, 2, 4, 6, 8} };

            //int[,] arr2 = new int[3, 5]; // 3 строки 5 столбцов

            // В 2х мерном массиве кол. столбцов во всех строках должно быть одинаковым
            int[,] myArray = new int[,]
            {
                {1, 3, 5, 7},
                {2, 3, 5, 7},
                {3, 3, 5, 7}
            };

            // Способы вывода 2х мерного массива

            // Вывод в строку
            //foreach (int i in myArray)
            //{
            //    Console.Write(i + " ");
            //}

            // Получение кол. эл. в заданном измерении
            //Console.WriteLine(myArray.GetLength(0)); 

            int height = myArray.GetLength(0);
            int width = myArray.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
