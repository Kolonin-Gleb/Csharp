using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_Оператор_объединения_с_null
{
    internal class Program
    {
        // Оператор null объединения ??
        // Позволяет устанавливать null значения для ссылочных типов (классов)
        // Синтаксический сахар
        static void Main(string[] args)
        {
            string str = "text"; // = null - другой результат

            // Проверка на то, что данные в str есть.
            // Если их нет, то вывод данных по умолч.
            Console.WriteLine(str ?? "нет текстовых данных");

            //int num = null;

            //Console.WriteLine(num ?? 0);

            // 
        }
    }
}
