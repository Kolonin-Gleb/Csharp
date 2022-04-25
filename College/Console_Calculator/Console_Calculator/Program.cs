using System;
using System.Collections.Generic;
using System.Linq;
using System.IO; // Для работы с файлами

namespace Console_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание файла для ведения истории калькулятора

            // Название файла - тек. дата и время
            string File_Name = DateTime.Now.ToString("ddMMyyyy");
            try
            {
                // Файл будет создаваться на диске C. Как поступить, если я хочу, чтобы он создавался в папке этого проекта?

                FileStream fileStream = new FileStream(string.Format("C:\\{0}.txt", File_Name), FileMode.Create);
                fileStream.Close();
                // Успешное создание файла истории
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка создания файла истории");
                Console.WriteLine(ex.Message);
            }

            // Список для логирования. Он динамический
            List<string> log_list = new List<string>();

            // Переменные
            double num1 = 0;
            double num2 = 0;
            double result = 0;
            string action = "";
            string confirm = "0";

            Console.Title = "Console Calculator";
            Console.WriteLine("Консольный калькулятор\n");

            while (confirm != "1")
            {
                Console.WriteLine("Введите 1 число: ");
                try
                {
                    log_list.Add(Console.ReadLine());
                    num1 = Convert.ToDouble(log_list.Last());
                }
                catch (Exception)
                {
                    log_list.Add("Ввод 1 числа осуществлён неверно!");
                    Console.WriteLine(log_list.Last());
                    continue;
                }

                Console.WriteLine("Введите 2 число: ");
                try
                {
                    log_list.Add(Console.ReadLine());
                    num2 = Convert.ToDouble(log_list.Last());
                }
                catch (Exception)
                {
                    log_list.Add("Ввод 2 числа осуществлён неверно!");
                    Console.WriteLine(log_list.Last());
                    continue;
                }

                Console.WriteLine("\t\t\tДоступные операции:");
                Console.WriteLine("+ - сложение");
                Console.WriteLine("- - вычитание");
                Console.WriteLine("* - умножение");
                Console.WriteLine("/ - деление");
                Console.WriteLine("% - остаток от деления");
                Console.WriteLine("^ - возведение 1 числа в степень = 2 числу");
                Console.WriteLine("root - взятие корня из 1 введённого числа");
                Console.Write("");

                Console.WriteLine("Введите операцию");
                try
                {
                    log_list.Add(Console.ReadLine());
                    action = log_list.Last();
                }
                catch (Exception)
                {
                    log_list.Add("Ввод операции осуществлён неверно!");
                    Console.WriteLine(log_list.Last());
                    continue;
                }

                // Обработка ввода пользователя
                switch (action)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        try
                        {
                            result = num1 / num2;
                        }
                        catch (Exception)
                        {
                            log_list.Add("Попытка деления на 0!");
                            Console.WriteLine(log_list.Last());
                            continue;
                        }
                        break;
                    case "%":
                        result = num1 % num2;
                        break;
                    case "^":
                        result = Math.Pow(num1, num2);
                        break;
                    case "root":
                        result = Math.Sqrt(num1);
                        break;
                    default:
                        log_list.Add("Введена несуществующая операция!");
                        Console.WriteLine(log_list.Last());
                        continue;
                }

                Console.WriteLine("\t\t\tВы не ошиблись в воде данных?");
                Console.WriteLine("0 - Да, хочу ввсети данные снова");
                Console.WriteLine("1 - Нет, жду результата");
                try
                {
                    log_list.Add(Console.ReadLine());
                    confirm = log_list.Last();
                }
                catch (Exception)
                {
                    log_list.Add("Ошибка считывания вашего ответа с консоли");
                    Console.WriteLine(log_list.Last());
                    continue;
                }
                if (confirm != "1")
                {
                    continue;
                }
                else
                {
                    log_list.Add("Результат операции:");
                    Console.WriteLine(log_list.Last() + "\n");

                    if (action == "root")
                    {
                        log_list.Add($" {num1} {action} = {result}");
                        Console.WriteLine(log_list.Last());
                    }
                    else
                    {
                        log_list.Add($"{num1} {action} {num2} = {result}");
                        Console.WriteLine(log_list.Last());
                    }
                }

                //Запись лога в файл
                try
                {
                    if (File.Exists(string.Format("C:\\{0}.txt", File_Name)))
                    {
                        StreamWriter streamWriter = new StreamWriter(string.Format("C:\\{0}.txt", File_Name)); // Открытие файла
                        
                        // Запись всех эл. в файл
                        foreach (var data_to_write in log_list)
                        {
                            streamWriter.WriteLine(data_to_write); // Запись в файл // После записи каждого эл. списка в файл нужно перенести строку
                        }
                        streamWriter.Close(); // Закрытие файла
                    }
                    else
                    {
                        Console.WriteLine("Файл для сохранения истории не найден!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка сохранения данных в файл");
                    Console.WriteLine(ex.Message);
                }
            }
            Console.Write("Нажмите любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
