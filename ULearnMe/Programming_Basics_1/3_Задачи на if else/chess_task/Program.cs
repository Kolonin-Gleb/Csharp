using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess_task
{
    internal class Program
    {
        enum Figures // Объявление перечисления
        {
            Pawn = 1,
            Castle = 2,
            Horse = 3,
            Bishop = 4,
            Queen = 5,
            King = 6,
        }

        /// <summary>
        /// Выводит информацию из Enum Figures в консоль.
        /// </summary>
        static void PrintFiguresInfo()
        {
            // Enum.GetVales() - возращает экземпляр System.Array, при этом каждому эл. массива
            // будет соответствовать член указанного перечисления.

            // Сохранение эл. перечисления в массив
            Array arr = Enum.GetValues(typeof(Figures));

            for (int i = 0; i < arr.Length; i++)
            {
                // TODO: Как это работает?
                Console.WriteLine("Фигура: {0}, номер для выбора = {0:D}", arr.GetValue(i));
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.Title = "Проверка возможности шахматного хода на пустой доске";

            Console.WriteLine("\tПроверка возможности шахматного хода на пустой доске\n");

            Console.WriteLine("Фигуры на выбор:");
            PrintFiguresInfo();


            Console.Write("Введите число соответствующее фигуре, которой производится ход: ");
            int figure = int.Parse(Console.ReadLine());

            Console.Write("Введите клетку фигуры в формате е4: ");
            string start_position = Console.ReadLine();

            Console.Write("Введите клетку на которую хотите сходить в формате е4: ");
            string end_position = Console.ReadLine();

            // Почему моё решение является антипаттерном?
            // https://habr.com/ru/post/312792/
            switch (figure)
            {
                case Figures.Pawn:
                    Console.WriteLine("Pawn");
                    break;
                case Figures.Castle:
                    Console.WriteLine("Castle");
                    break;
                case Figures.Horse:
                    Console.WriteLine("Horse");
                    break;
                case Figures.Bishop:
                    Console.WriteLine("Bishop");
                    break;
                case Figures.Queen:
                    Console.WriteLine("Queen");
                    break;
                case Figures.King:
                    Console.WriteLine("King");
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }

            Console.WriteLine("Нажмите любую клавишу для завершения");
            Console.ReadKey();

        }
    }
}
