using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Эта программа позволяет добавлять записи в списк и проводить над ним различные операции.
namespace ClassApp
{
    class Program
    {
        //static List<string> lstProduct = new List<string>();
        static ArrayList lstProduct = new ArrayList(); //Данный список не типизированный;
        //enum Act { insert, update, delete, select }
        static string cmd = "null", rowValue;
        static int index = -1;
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите команду:");
            cmd = Console.ReadLine().ToLower();
            switch (cmd)
            {
                case "insert":
                    Console.WriteLine("Введите значение строки:");
                    rowValue = Console.ReadLine();
                    lstProduct.Add(rowValue);
                    break;
                case "update":
                    Console.WriteLine("Введите индекс записи");
                    try
                    {
                        index = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите новую строку");
                        rowValue = Console.ReadLine();
                        lstProduct[index] = rowValue;
                    }
                    catch
                    {
                        Console.WriteLine("Не верный ввод числа");
                    }
                    break;
                case "delete":
                    Console.WriteLine("Введите индекс записи для удаления:");
                    try
                    {
                        index = Convert.ToInt32(Console.ReadLine());
                        lstProduct.RemoveAt(index);
                    }
                    catch
                    {
                        Console.WriteLine("Не верный ввод числа");
                    }
                    break;
                case "select":
                    if (lstProduct.Count == 0)
                    {
                        Console.WriteLine("Записей нет");
                    }
                    else
                    {
                        Console.WriteLine(string.Format("Количество записей: {0}", lstProduct.Count));
                        for (int i = 0; i < lstProduct.Count; i++)
                        {
                            Console.WriteLine(string.Format("ID {0} - Значение: {1}", i, lstProduct[i]));
                        }
                    }
                    break;
                case "help":
                    Console.WriteLine("Допустимые команды: insert, update, delete, select");
                    break;
                default:
                    Console.WriteLine("Ошибка ввода команды");
                    break;
            }
            Console.ReadKey();
            Console.Clear();
            Main(args);
        }
    }
}

