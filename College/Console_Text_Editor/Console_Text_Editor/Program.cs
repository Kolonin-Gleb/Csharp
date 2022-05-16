using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading; //Пространство имён для работы с многопоточностью
using System.IO;

using System.Text.RegularExpressions; // Для регулярных выражений

namespace StreamThreadApp
{
    class Program
    {
        static string File_Name = null; 
        static string File_Type = null;
        static string File_Content;

        static void Main(string[] args)
        {
            Console.Title = "Text Editor by Gleb";

            Console.WriteLine("Введите одну из команд: Create, Delete, Read, Write, Copy, Exit");
            string cmd = Console.ReadLine().ToLower();
            switch (cmd)
            {
                case "create":

                    Console.WriteLine("Введите название нового файла или Enter, чтобы использовать текущую дату и время в качестве имени:");
                    File_Name = Console.ReadLine();
                    if (File_Name == "")
                    {
                        File_Name = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss"); // Имя файла по умолчанию
                    }

                    Console.WriteLine("Введите расширение нового файла (txt):");
                    File_Type = Console.ReadLine();
                    try
                    {
                        FileStream fileStream = new FileStream(string.Format("C:\\{0}.{1}", File_Name, File_Type), FileMode.Create);
                        fileStream.Close();
                        Console.WriteLine("Файл успешно создан!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    //finaly - не обязательный блок, который срабатывает в любом случает от предыдущих блоков
                    finally
                    {
                        Console.WriteLine("Нажмите Enter");
                        Console.ReadKey();
                        Console.Clear();
                        Main(args);
                    }
                    break;
                case "delete":
                    Console.WriteLine("Введите название удаляемого файла:");
                    File_Name = Console.ReadLine();
                    try
                    {
                        if (File.Exists(string.Format("C:\\{0}.txt", File_Name)))
                        {
                            File.Delete(string.Format("C:\\{0}.txt", File_Name));
                        }
                        else
                        {
                            Console.WriteLine("Указанного файла не существует!"); // Или его расширение не txt
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Нажмите Enter");
                        Console.ReadKey();
                        Console.Clear();
                        Main(args);
                    }
                    break;
                case "read":
                    Console.WriteLine("Введите название читаемого файла:");
                    File_Name = Console.ReadLine();
                    try
                    {
                        if (File.Exists(string.Format("C:\\{0}.txt", File_Name)))
                        {
                            StreamReader streamReader = new StreamReader(string.Format("C:\\{0}.txt", File_Name));
                            Console.Write(string.Format("{0}", streamReader.ReadToEnd()));
                            streamReader.Close();
                        }
                        else
                        {
                            Console.WriteLine("Указанного файла не существует!"); // Или его расширение не txt
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Нажмите Enter");
                        Console.ReadKey();
                        Console.Clear();
                        Main(args);
                    }
                    break;
                case "write":
                    Console.WriteLine("Введите название файла:");
                    File_Name = Console.ReadLine();
                    try
                    {
                        if (File.Exists(string.Format("C:\\{0}.txt", File_Name)))
                        {
                            Console.WriteLine("Введите команду для исполнения:");
                            Console.WriteLine("upper - для перевода всех букв в файле в верхний регистр");
                            Console.WriteLine("lower - для перевода всех букв в файле в нижний регистр");
                            Console.WriteLine("replace - для замены подстрок в текстовом документе");
                            Console.WriteLine("search - для поиска подстроки в файле");
                            Console.WriteLine("write - чтобы просто дописать информацию в файл");
                            string comand = Console.ReadLine();

                            if (comand == "upper")
                            {
                                File_Content = File.ReadAllText(string.Format("C:\\{0}.txt", File_Name));
                                File_Content = File_Content.ToUpper();
                                File.WriteAllText(string.Format("C:\\{0}.txt", File_Name), File_Content);
                            }
                            else if (comand == "lower")
                            {
                                File_Content = File.ReadAllText(string.Format("C:\\{0}.txt", File_Name));
                                File_Content = File_Content.ToLower();
                                File.WriteAllText(string.Format("C:\\{0}.txt", File_Name), File_Content);
                            }
                            else if (comand == "replace")
                            {
                                Console.WriteLine("Введите строку, для замены:");
                                string searchText = Console.ReadLine();
                                Console.WriteLine("Введите строку, которой заменяем:");
                                string replaceText = Console.ReadLine();

                                File_Content = File.ReadAllText(string.Format("C:\\{0}.txt", File_Name));

                                File_Content = File_Content.Replace(searchText, replaceText);

                                // Запись изменений в файл
                                File.WriteAllText(string.Format("C:\\{0}.txt", File_Name), File_Content);
                            }
                            else if (comand == "search")
                            {
                                Console.WriteLine("Введите строку, для поиска:");
                                string searchText = Console.ReadLine();

                                File_Content = File.ReadAllText(string.Format("C:\\{0}.txt", File_Name));

                                Regex regexpattern = new Regex(searchText);

                                File_Content = regexpattern.Match(File_Content).ToString();

                                Console.WriteLine("Результат поиска: ");
                                Console.WriteLine(File_Content);
                            }
                            else if (comand == "write")
                            {
                                Console.WriteLine("Укажите ниже текст, который хотите сохранить в файле:");
                                string New_Text = Console.ReadLine();
                                StreamWriter streamWriter = new StreamWriter(string.Format("C:\\{0}.txt", File_Name));
                                streamWriter.WriteLine(New_Text);
                                streamWriter.Close();
                            }
                            else
                            {
                                Console.WriteLine("Выбрана не существующая команда!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Указанного файла не существует!"); // Или его расширение не txt
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Нажмите Enter");
                        Console.ReadKey();
                        Console.Clear();
                        Main(args);
                    }
                    break;
                case "copy":
                    Console.WriteLine("Введите название файла:");
                    File_Name = Console.ReadLine();
                    try
                    {
                        if (File.Exists(string.Format("C:\\{0}.txt", File_Name)))
                        {
                            Console.WriteLine("Введите название нового файла:");
                            string new_File_Name = Console.ReadLine();
                            File.Copy(string.Format("C:\\{0}.txt", File_Name), string.Format("C:\\{0}.txt", new_File_Name));
                        }
                        else
                        {
                            Console.WriteLine("Указанного файла не существует!"); // Или его расширение не txt
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Нажмите Enter");
                        Console.ReadKey();
                        Console.Clear();
                        Main(args);
                    }
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Не верно введена команда!");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                    break;
            }
        }
    }
}
