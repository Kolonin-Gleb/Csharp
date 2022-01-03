using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static string Reverse(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new String(arr);
        }

        static void Main(string[] args)
        {
            // Итог: Развернуть число через строку - сложна!
            string str = "123";
            str = ReverseNumber.Reverse(str);
            Console.WriteLine(str);
        }

    }
}
