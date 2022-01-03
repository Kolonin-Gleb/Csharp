using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockAngle
{
    class ClockAngle
    {
        static void Main(string[] args)
        {
            // Входные данные - число от 1 до 24 (24 = 0) - соответствует тек. часу в 12 часовом формате
            // Минутная стрелка всегда указывает на 24 (0)

            // Выходные данные - угол между стрелками от 0 до 330

            Console.Write("Введите час от 1 до 24: ");
            int hour = int.Parse(Console.ReadLine());
            int angle = 0;

            if (hour == 12 || hour == 24)
            {
                angle = 0;
            }
            else if (hour < 12) // 1 < hour < 12
            {
                angle = hour * 30;
            }
            else // 12 < hour < 24
            {
                angle = hour * 30 - 360;
            }
            Console.WriteLine("Угол между минутной стрелкой и часовой = " + angle);
        }
    }
}
