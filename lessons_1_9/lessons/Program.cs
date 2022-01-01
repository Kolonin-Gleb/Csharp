using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Учебный проект";

            //Console.WriteLine("Введите данные: ");
            //string user_data;
            //user_data = Console.ReadLine();
            //Console.WriteLine("Ваши данные: " + user_data);

            string str;

            //str = "1,9";
            str = "1.9";

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            double a = Convert.ToDouble(str, numberFormatInfo);

            Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}
