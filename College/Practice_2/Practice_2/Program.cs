using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Упражнение 2\n");

            //double num1, num2;
            //Console.WriteLine("Введите 1 число");
            //num1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите 2 число");
            //num2 = Convert.ToDouble(Console.ReadLine());

            //if (num1 > num2)
            //    Console.WriteLine("Число 1 > числа 2");
            //else if (num1 < num2)
            //    Console.WriteLine("Число 1 < числа 2");
            //else
            //    Console.WriteLine("Число 1 = числу 2");


            //Console.WriteLine("Упражнение 3\n");
            //int num;

            //Console.WriteLine("Введите целое число");
            //num = int.Parse(Console.ReadLine());

            //if (num == 5 || num == 10)
            //    Console.WriteLine("Число либо равно 5, либо равно 10");
            //else
            //    Console.WriteLine("Неизвестное число");


            //Console.WriteLine("Упражнение 4\n");

            //double deposit, income, bonuses = 15;
            //Console.WriteLine("Введите сумму вклада");
            //deposit = Convert.ToDouble(Console.ReadLine());

            //income = deposit / 100;
            //if (deposit < 100)
            //    // начисляется 5%
            //    income *= 5;
            //else if (deposit >= 100 && deposit <= 200)
            //    //начисляется 7%.
            //    income *= 7;
            //else if (deposit > 200)
            //    // начисляется 10%.
            //    income *= 10;

            //deposit += income;
            //deposit += bonuses;
            //Console.WriteLine("Сумма вклада с начисленными процентами:");
            //Console.WriteLine(deposit);


            //    Console.WriteLine("Упражнение 5\n");

            //    double num1, num2;
            //    Console.WriteLine("Введите 1 число");
            //    num1 = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("Введите 2 число");
            //    num2 = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("Доступные операции:");
            //    Console.WriteLine("1 - Сложение 2 - Вычитание 3 - Умножение");

            //    Console.WriteLine("Введите номер операции:");
            //    int choice = int.Parse(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case 1:
            //            Console.WriteLine("Вы выбрали операцию - Сложение");
            //            Console.WriteLine($"Результат операции = {num1 + num2}");
            //            break;
            //        case 2:
            //            Console.WriteLine("Вы выбрали операцию - Вычитание");
            //            Console.WriteLine($"Результат операции = {num1 - num2}");
            //            break;
            //        case 3:
            //            Console.WriteLine("Вы выбрали операцию - Умножение");
            //            Console.WriteLine($"Результат операции = {num1 * num2}");
            //            break;
            //        default:
            //            Console.WriteLine("Выбранная операция не определена!");
            //            break;
            //    }
            //    Console.ReadKey();
            //}


            Console.WriteLine("Упражнение 8\n");
            int num = 35;

            switch (num % 6)
            {
                case 0:
                    Console.WriteLine($"Число {num} кратно 6");
                    break;
                default:
                    Console.WriteLine($"Число {num} не кратно 6");
                    break; 
            }

            Console.ReadKey();
        }
    }
}
