using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Функции_и_методы
{
    internal class Program
    {
        static void SayHello()
        {
            Console.WriteLine("Hello");
        }
        // Короткая версия метода
        static void Sum(int x, int y) => Console.WriteLine($"{x} + {y} = { x + y }");

        static void PrintPerson(string name, int age = 1, string company = "Undefined")
        {
            Console.WriteLine($"Name: {name}  Age: {age}  Company: {company}");
        }

        static void Main(string[] args)
        {
            // В С# функции не могут существовать вне класса, поэтому они = методам
            SayHello();

            Sum(6, 4);

            // Передача параметров не по порядку
            PrintPerson("Tom", company: "Microsoft", age: 37);
        }
    }
}
