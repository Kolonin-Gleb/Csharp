using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSplitFiles
{
    // Класс ForeignCitizen - унаследован от класса Citizen.
    // Данный класс является запечатанным - не может быть унаследован другим классом
    sealed class ForeignCitizen : Citizen
    {
        // 1. Внутренние поля класса
        private string foreignPassport; // номер заграничного паспорта
        private DateTime visaOpen; // дата открытия визы
        private DateTime visaClose; // дата закрытия визы

        // 2. Конструктор класса - вызывает конструктор базового класса
        public ForeignCitizen(string _name, string _surname, bool _sex,
          string _password, string _address,
          string _foreignPassport, DateTime _visaOpen, DateTime _visaClose)
          : base(_name, _surname, _sex, _password, _address)
        {
            foreignPassport = _foreignPassport;
            visaOpen = _visaOpen;
            visaClose = _visaClose;
        }

        // 3. Свойства для доступа к полям класса
        public string ForeignPassport
        {
            get { return foreignPassport; }
            set { foreignPassport = value; }
        }

        public DateTime VisaOpen
        {
            get { return visaOpen; }
            set { visaOpen = value; }
        }

        public DateTime VisaClose
        {
            get { return visaClose; }
            set { visaClose = value; }
        }

        // 4. Метод Print () - вывод полей класса
        public new void Print()
        {
            base.Print(); // вызов метода базового класса
            Console.WriteLine("foreignPassport: {0}", foreignPassport);
            Console.WriteLine("visaOpen: {0}", visaOpen);
            Console.WriteLine("visaClose: {0}", visaClose);
        }
    }
}

