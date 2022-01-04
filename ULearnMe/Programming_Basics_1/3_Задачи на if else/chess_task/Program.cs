using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess_task
{
    class Program
    {
        // Объявление перечисления
        enum Figures 
        {
            Pawn = 1,
            Castle = 2,
            Horse = 3,
            Bishop = 4,
            Queen = 5,
            King = 6,
        }
        enum FiguresColors
        {
            White = 1,
            Black = 2,
        }

        /// <summary>
        /// Выводит информацию из Enum Figures в консоль.
        /// </summary>
        static void PrintFiguresInfo() // TODO: Можно ли сделать так, чтобы этот метод работал с лююыми enum?
        {
            // Enum.GetVales() - возращает экземпляр System.Array, при этом каждому эл. массива
            // будет соответствовать член указанного перечисления.

            // Сохранение эл. перечисления в массив
            Array arr = Enum.GetValues(typeof(Figures));

            for (int i = 0; i < arr.Length; i++)
            {
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

            // Нужно также органиизовать ввод цвета фигуры, т.к. 
            // чёрные и белые фигуры имеют разные возможности для хода.

            Console.Write("Введите клетку фигуры в формате е4: ");
            string start_position = Console.ReadLine();

            Console.Write("Введите клетку на которую хотите сходить в формате е4: ");
            string end_position = Console.ReadLine();

            switch ((int)figure)
            {
                case (int)Figures.Pawn:
                    Console.WriteLine("Pawn");
                    break;
                case (int)Figures.Castle:
                    Console.WriteLine("Castle");
                    break;
                case (int)Figures.Horse:
                    Console.WriteLine("Horse");
                    break;
                case (int)Figures.Bishop:
                    Console.WriteLine("Bishop");
                    break;
                case (int)Figures.Queen:
                    Console.WriteLine("Queen");
                    break;
                case (int)Figures.King:
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
