using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Для коментирования кода Ctrl+K+C, для разкомментирования Ctrl+K+U
            //string str1;
            //int int1 = 1, int2 = 12;
            //const string constStr = "Hello World!";
            //decimal decVar = 12.12m;
            //str1 = "Word";
            //Console.Write(str1+"\n");
            //Console.WriteLine(int1);
            //Console.WriteLine(int2);
            /* if (<Условие>)
             * {
             * <Оператор 1>
             * <Оператор 3>
             * }
             * else является не обязательным элементом
             * <Оператор 2>
             * switch(<Коллекция значений>)
             * {
             * case <Значение из коллекции>:
             * <оператор>
             * break;
             * default:
             * <операторы>
             * break;
             * goto <Название значения из коллекции>
             * }
             * Тернарный оператор, аналог if - для бинанрых условия
             * <Переменная> = (<Условие>) ? <Истинное значение> : <Ложное значение>;
             */
            //int number;
            //Console.WriteLine("Введите любое число от 1 до 10");
            //number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine((number > 5) ? "Число больше 5" : "Число меньше 5");
            //if (number > 5)
            //{
            //    Console.WriteLine("Число больше 5");
            //}
            //else
            //{
            //    if (number == 5)
            //    {
            //        Console.WriteLine("Число равно 5");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Число меньше 5");
            //    }
            //}
            //string number_month = "null";
            //Console.WriteLine("Введите номер месяца");
            //number_month = Console.ReadLine();
            //switch (number_month)
            //{
            //    case "1": case "2": case "12":
            //        Console.WriteLine("Зима");
            //        break;
            //    case "3": case "4": case "5":
            //        Console.WriteLine("Весна");
            //        break;
            //    case "6": case "7": case "8":
            //        Console.WriteLine("Лето");
            //        break;
            //    case "9": case "10": case "11":
            //        Console.WriteLine("Осень");
            //        break;
            //    default:
            //        Console.WriteLine("Не верный ввод данных");
            //        break;
            //}
            //string str = "Hellow";
            //Console.WriteLine("Введите индекс от 0 до 5");
            //int index = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(str[index]);
            //int[] singlMass = new int[] { 1, 2, 5, 6, 3 };
            //singlMass[0] = 1;
            //singlMass[1] = 2;
            //singlMass[2] = 5;
            //singlMass[3] = 6;
            //singlMass[4] = 3;
            //Console.WriteLine(singlMass[0]);
            //Console.WriteLine(singlMass[1]);
            //Console.WriteLine(singlMass[2]);
            //Console.WriteLine(singlMass[3]);
            //Console.WriteLine(singlMass[4]);
            /*Перечисление из коллекции
             * foreach(<Тип данных лемента коллеции> <Название переменной> in <Название коллеции>)
             * {
             *      <Тело цикла>
             * }
             *
             *Цикл с итерацией 
             * for(<Объявление и заполнение итератора>; <Условие для выполнения цикла>; <Действие с интератором>)
             * {
             *      <Тело цикла>
             * }
             * 
             * Цикл с пост-учловием
             * do
             * {
             *      <Тело цикла>
             * }
             * while(<Условие>)
             *
             *Цикл с пред-условием
             * while(<Условие>)
             * {
             *      <Текло цикла>
             * }
             */
            //Console.WriteLine("Введите любую строку");
            //string str = Console.ReadLine();
            //Console.WriteLine("Нажмите любую клавишу");
            //int index = 1;
            //foreach (char symb in str)
            //{
            //    Console.WriteLine("№ "+index +" : "+ symb);
            //    index++;
            //}
            //int[] Mass;
            //int MassSIze;
            //Console.WriteLine("Введите размерность массива");
            //MassSIze = Convert.ToInt32(Console.ReadLine());
            //Mass = new int[MassSIze];
            //Random random = new Random();
            //for(int i = 0; i < MassSIze; i++)
            //{
            //    Mass[i] = random.Next(1, 100);
            //    Console.Write(Mass[i] + " "); 
            //}
            //Console.WriteLine("Как вывести массив? В прямом или обратном порядке?");
            //string cmd = Console.ReadLine();
            //switch(cmd)
            //{
            //    case "Прямой":
            //        for (int i = 0; i < MassSIze; i++)
            //        {
            //            Console.WriteLine("Index: " + i + " " + Mass[i]);
            //        }
            //        break;
            //    case "Обратный":
            //        for (int i = MassSIze-1; i>=0; i--)
            //        {
            //            Console.WriteLine("Index: " + i + " " + Mass[i]);
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Erorr!");
            //        break;
            //}
            //bool contin = true;
            //int count = 0;
            //do
            //{
            //    Console.WriteLine("Выполнить цикл?");
            //    switch (Console.ReadLine())
            //    {
            //        case "Yes":
            //        default:
            //            contin = true;
            //            break;
            //        case "No":
            //            contin = false;
            //            break;
            //    }
            //    Console.WriteLine(count++);
            //} while (contin);
            //while (contin)
            //{
            //    Console.WriteLine("Выполнить цикл?");
            //    switch (Console.ReadLine())
            //    {
            //        case "Yes":
            //        default:
            //            contin = true;
            //            break;
            //        case "No":
            //            contin = false;
            //            break;
            //    }
            //    Console.WriteLine(count++);
            //}
            Console.WriteLine("Конец выполнения цикла");
            Console.ReadKey();
            Console.Clear();
            Main(args);
        }
    }
}
