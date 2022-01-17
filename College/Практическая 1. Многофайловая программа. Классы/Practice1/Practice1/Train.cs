using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Train : TransportationDevice
    {
        // 1. Внутренние поля класса
        private int length; // в метрах
        private float maxLoad; // в тоннах

        // 2. Конструктор класса - вызывает конструктор базового класса
        public Train(string _energySource, string _controlSystem, DateTime _productionDate,
            int _length, float _maxLoad) : base(_energySource, _controlSystem, _productionDate)
        {
            length = _length;
            maxLoad = _maxLoad;
        }

        // 3. Свойства доступа к полям класса
        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public float MaxLoad
        {
            get { return maxLoad; }
            set { maxLoad = value; }
        }

        // 4. Метод, который виводит значения полей класса
        public new void Print()
        {
            base.Print(); // вызов метода базового класса
            Console.WriteLine("length: {0}", length);
            Console.WriteLine("maxLoad: {0}", maxLoad);
        }
    }
}
