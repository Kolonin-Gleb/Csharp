using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Минимум_параболы
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Поиск координат вершины параболы");

            // Тестирование
            ParabolaVertex(1, 2, 3);
            ParabolaVertex(0, 3, 2);
            ParabolaVertex(1, -2, -3);
            ParabolaVertex(5, 2, 1);
            ParabolaVertex(4, 3, 2);
            ParabolaVertex(0, 4, 5);
        }

        // a > 0
        // b и c - любые
        static void ParabolaVertex(int a, int b, int c)
        {
            if (a == 0)
            {
                Console.WriteLine("Это не парабола, поэтому вершину вычислить нельзя!");
            }
            else
            {
                double min_y = 0;
                double min_x = 0;

                min_x = -b / (2.0 * a);

                min_y += min_x + c;

                Console.WriteLine("min_x = " + min_x.ToString() + "\t" + "min_y = " + min_y.ToString());
            }

            // y = ax^2 + bx + c - график параболы
            // Поиск вершины пораболы осуществляется по формуле:
            // Приравняв производную к нулю y'(x) = 0,
            // легко найти формулу для искомого x = - b / 2a
        }
    }
}
