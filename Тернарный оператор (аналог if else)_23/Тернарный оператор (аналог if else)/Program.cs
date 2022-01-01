using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тернарный_оператор__аналог_if_else_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool acessAllowed = false;
            string correctPassword = "qwerty";
            Console.WriteLine("Введите пароль (подсказка = qwerty)");
            string userPassword = Console.ReadLine();

            if (userPassword == correctPassword)
            {
                acessAllowed = true;
                Console.WriteLine("Доступ разрешён");
            }
            else
            {
                Console.WriteLine("Доступ запрещён");
            }
            Console.ReadLine();

            // Тернарный оператор
            // 
            // [переменная = условие] ? [действие если условие - true] : [действие если условие - false]
            //

            acessAllowed = userPassword == correctPassword ? true : false;

            if (acessAllowed)
            {
                Console.WriteLine("Доступ разрешён");
            }
            else
            {
                Console.WriteLine("Доступ запрещён");
            }
            Console.ReadLine();
        }
    }
}
