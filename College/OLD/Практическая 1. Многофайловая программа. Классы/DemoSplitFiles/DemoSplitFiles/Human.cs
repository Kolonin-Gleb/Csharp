using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSplitFiles
{
    // Класс Human - описывает человека
    internal class Human
    {
        // 1. Внутренние поля класса
        protected string name; // Имя
        protected string surname; // Фамилия
        protected bool sex; // Пол: true - женский, false - мужской

        // 2. Конструктор с 3 параметрами
        public Human(string _name, string _surname, bool _sex)
        {
            name = _name;
            surname = _surname;
            sex = _sex;
        }

        // 3. Свойства для доступа к внутренним полям класса
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public bool Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        // 4. Метод Print () - выводит имена полей класса на экран
        public void Print()
        {
            Console.WriteLine("name: {0}", name);
            Console.WriteLine("surname: {0}", surname);
            if (sex)
            {
                Console.WriteLine("sex: Female");
            }
            else
            {
                Console.WriteLine("sex: Male");
            }
        }
    }
}
