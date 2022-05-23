using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class TransportationDevice
    {
        // 1. Внутренние поля класса
        protected string energySource; // Источник энергии
        protected string controlSystem; // Система успрвления
        protected DateTime productionDate; // Дата производства

        // 2. Конструктор с 3 параметрами
        public TransportationDevice(string _energySource, string _controlSystem, DateTime _productionDate)
        {
            energySource = _energySource;
            controlSystem = _controlSystem;
            productionDate = _productionDate;
        }

        // 3. Свойства для доступа к внутренним полям класса
        public string EnergySource
        {
            get { return energySource; }
            set { energySource = value; }
        }

        public string ControlSystem
        {
            get { return controlSystem; }
            set { controlSystem = value; }
        }

        public DateTime ProductionDate
        {
            get { return productionDate; }
            set { productionDate = value; }
        }

        // 4. Метод Print () - выводит имена полей класса на экран
        public void Print()
        {
            Console.WriteLine("energySource: {0}", energySource);
            Console.WriteLine("controlSystem: {0}", controlSystem);
            Console.WriteLine("productionDate: {0}", productionDate);
        }
    }
}
