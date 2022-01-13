using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSplitFiles
{
    // Класс Citizen - унаследован от класса Human
    internal class Citizen : Human
    {
        // 1. Внутренние поля класса
        protected string password; // Номер паспорта
        protected string address; // Адрес проживания

        // 2. Конструктор класса - вызывает конструктор базового класса
        public Citizen(string _name, string _surname, bool _sex,
            string _password, string _address) : base(_name, _surname, _sex)
        {
            password = _password;
            address = _address;
        }

        // 3. Свойства доступа к полям класса
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        // 4. Метод, который виводит значения полей класса
        public new void Print()
        {
            base.Print(); // вызов метода базового класса
            Console.WriteLine("password: {0}", password);
            Console.WriteLine("address: {0}", address);
        }
    }
}

