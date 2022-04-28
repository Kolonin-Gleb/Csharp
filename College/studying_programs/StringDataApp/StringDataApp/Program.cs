using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StringDataApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Обяъвление независимого экземпляра даты и времени
            //DateTime date = new DateTime(1993, 4, 15);
            //DateTime date_full = new DateTime(1993, 4, 15, 16, 10, 20);
            //Console.WriteLine(date);
            //Console.WriteLine(date_full);
            //Console.WriteLine(date_full.ToShortDateString());
            //Console.WriteLine(date_full.ToLongTimeString());
            //Console.WriteLine(date_full.ToLongDateString());
            //Console.WriteLine(date_full.ToShortTimeString());
            //Console.WriteLine(date_full.ToString("День dd меяц MM год yyyy"));
            //Цикл для вывода текущей даты и времени с момощью свойства Now 
            //for (int i = 0; ;i++)
            //{
            //    Thread.Sleep(1000);
            //    Console.Clear();
            //    Console.WriteLine(DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString());
            //}
            //Свойства получения отдельных частей даты
            //Console.WriteLine("Возврат даты: "+DateTime.Now.Date);
            //Console.WriteLine("Возврат дня месяца: "+DateTime.Now.Day);
            //Console.WriteLine("Возврат дня недели: "+DateTime.Now.DayOfWeek);
            //Console.WriteLine("Возврат дня года: "+DateTime.Now.DayOfYear);
            //Console.WriteLine("Возврат часа: "+DateTime.Now.Hour);
            //Console.WriteLine("Возврат значения типа времени (местное или иное): "+DateTime.Now.Kind);
            //Console.WriteLine("Возврат миллисекунд: "+DateTime.Now.Millisecond);
            //Console.WriteLine("Возрат минут: "+DateTime.Now.Minute);
            //Console.WriteLine("Возврат месяца: "+DateTime.Now.Month);
            //Console.WriteLine("Возврат текущей даты и времени: "+DateTime.Now);
            //Console.WriteLine("Возврат секунды: "+DateTime.Now.Second);
            //Console.WriteLine("Возврат числа тактов: "+DateTime.Now.Ticks);
            //Console.WriteLine("Возврат времени дня: "+DateTime.Now.TimeOfDay);
            //Console.WriteLine("Возвращает текущую дату: "+DateTime.Today);
            //Console.WriteLine("Возврат года: "+DateTime.Now.Year);
            //Методы работы с датой и временем
            //DateTime date = new DateTime(1993, 4, 15);
            ////TimeSpan - интервал времени, дни, часы, минуты, секунды, миллисекунды
            //TimeSpan date_curreent = new TimeSpan(100,0,0,0,0);
            //Console.WriteLine(date.Add(date_curreent));
            Console.WriteLine("Текущая дата и время:" + DateTime.Now);
            //Console.WriteLine("К текущей дате прибавить 250 дней:" + DateTime.Now.AddDays(250));
            //Console.WriteLine("От текущей даты отнять 500 дней:" + DateTime.Now.AddDays(-500));
            //Console.WriteLine("К текущему времени прибавить 10 часов: " + DateTime.Now.AddHours(10).ToLongTimeString());
            //Console.WriteLine("От текущего времени отнять 60 минут: " + DateTime.Now.AddMinutes(-60).ToLongTimeString());
            //Console.WriteLine("К текущей дате прибавить 72 месяца: " + DateTime.Now.AddMonths(72));
            //Console.WriteLine("К от текущей даты отнять 30 лет:" + DateTime.Now.AddYears(-30));

            //РАБОТА СО СТРОКАМИ
            //Конкатенация строк, и подстрок
            //string mainString = "Объектно-", second_String = "Ориентированое", therd_stridng = "программирование";
            ////Примитивная конкатенация
            //Console.WriteLine(mainString+second_String+" "+therd_stridng);
            //Console.WriteLine("Объектно-" + "Ориентированое" + " "+ "программирование");
            ////Функция join
            //Console.WriteLine(string.Join("*", mainString, second_String, therd_stridng));
            //Console.WriteLine(string.Join("*", "Объектно-", "Ориентированое", "программирование"));
            ////Функция format
            //Console.WriteLine(string.Format("{0}{1} {2} или {2} {0}{1}", mainString, second_String, therd_stridng));
            //Console.WriteLine(string.Format("{0}{1} {2} или {2} {0}{1}", "Объектно-", "Ориентированое", "программирование"));
            //Сравнение строк метод Comare
            //string First_String = "Программирование", Second_String = "Базы данных";
            ////Если первая строка стоит выше по алфовиту то возвразщается число меньше 0, если ниже то конкретное число больше 0, и если строки равны то возвращается 0
            //int res = string.Compare(First_String, Second_String);
            ////int res = string.Compare(Second_String, Second_String);
            //if (res < 0)
            //{
            //    Console.WriteLine(string.Format("Строка '{0}' перед строкой '{1}'", First_String, Second_String));
            //}
            //else
            //{
            //    if (res > 0)
            //    {
            //        Console.WriteLine(string.Format("Строка '{0}' после строкой '{1}'", First_String, Second_String));
            //    }
            //    else
            //    {
            //        Console.WriteLine(string.Format("Строка '{0}' равна '{1}'", First_String, Second_String));
            //    }
            //}
            //Поиск индекса по введённому символу или подстроке метод IndexOf
            //string StrIndex = "Программирование";
            //Console.WriteLine(StrIndex.IndexOf('г'));
            //Console.WriteLine(StrIndex.IndexOf('м'));
            //Console.WriteLine(StrIndex.IndexOf("ова"));
            ////Разделение строки на множество подстрок Split
            //string StrSplit = "Основы проектирования баз данных";
            //string[] words = StrSplit.Split(' ');
            //foreach (string substr in words)
            //{
            //    Console.WriteLine(substr);
            //}
            //for (int i = 0; i<words.Length; i++)
            //{
            //    Console.WriteLine(string.Format("№ слова {0} - {1}", i+1, words[i]));
            //}
            ////Исключение символов из строки Trim
            //StrSplit = StrSplit.Trim('О','х');
            //Console.WriteLine(StrSplit);
            ////Вывод подстроки Substring
            //Console.WriteLine(StrSplit.Substring(3, 10));
            //foreach(string subst in words)
            //{
            //    Console.Write(subst.Substring(0, 1).ToUpper());
            //}
            //Вставка подстроки в строку метод Insert
            //string insertedStr = " реляционных";
            //Console.WriteLine(StrSplit.Insert(StrSplit.IndexOf('я') + 1, insertedStr));
            ////Удаление символов или подстроки из строки Remove
            //Console.WriteLine(StrSplit.Remove(5));
            //Console.WriteLine(StrSplit.Remove(0,6));
            ////Замена в строке Replace
            //Console.WriteLine(StrSplit.Replace("баз данных", "на языке SQL"));
            //Console.WriteLine(StrSplit.Replace('н', 'h'));
            ////Перевод текста в верхний регист метод ToUpper, в нижний ToLower
            //Console.WriteLine(StrSplit.ToUpper());
            //Console.WriteLine(StrSplit.ToLower());


            //int [,] DDMass;
            //int row, col;
            //Console.WriteLine("Введите количество строк");
            //row = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите количество столбцов");
            //col = Convert.ToInt32(Console.ReadLine());
            //DDMass = new int[row, col];
            //Random random = new Random();
            //for(int i = 0; i< row; i++)
            //{
            //    for (int j = 0; j<col; j++)
            //    {
            //        DDMass[i, j] = random.Next(1, 100);
            //        Console.Write(DDMass[i, j]+"\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Введите номер номер ячейки, которую хотите вывести. Формат 0:0");
            //string cellNum = Console.ReadLine();
            //int celR = Convert.ToInt32(cellNum.Substring(0, cellNum.IndexOf(':')));
            //int celC = Convert.ToInt32(cellNum.Substring(cellNum.IndexOf(':') + 1, cellNum.Length - cellNum.IndexOf(':') - 1));
            //Console.WriteLine(DDMass[celR, celC]);
            Console.ReadKey();
        }
    }
}
