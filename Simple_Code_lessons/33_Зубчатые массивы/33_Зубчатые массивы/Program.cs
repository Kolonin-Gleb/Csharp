using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Зубчатые_массивы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Зубчатый массив - 1м массив, что содержит в себе массивы,
            // размеры которых могут быть разными

            // Создание зубчатого массива
            //int[][] myArray = new int[3][];

            //// Создание 2х мерного прямоугольного массива
            //int[,] myArray2 = new int[10, 2];

            //// Ранг массива - кол. измерений массива
            //int myArrayRank = myArray.Rank;
            //int myArray2Rank = myArray2.Rank;

            //Console.WriteLine("myArrayRank = " + myArrayRank);
            //Console.WriteLine("myArray2Rank = " + myArray2Rank);

            int[][] nums = new int[3][];
            nums[0] = new int[2] { 1, 2 };          // выделяем память для первого подмассива
            nums[1] = new int[3] { 1, 2, 3 };       // выделяем память для второго подмассива
            nums[2] = new int[5] { 1, 2, 3, 4, 5 }; // выделяем память для третьего подмассива

            // Используя вложенные циклы, можно перебирать зубчатые массивы

            Console.WriteLine("Перебор с помощью цикла foreach");
            foreach (int[] row in nums)
            {
                foreach (int num in row)
                {
                    Console.Write($"{num} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Перебор с помощью цикла for");
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums[i].Length; j++)
                {
                    Console.Write($"{nums[i][j]} \t");
                }
                Console.WriteLine();
            }
        }
    }
}
