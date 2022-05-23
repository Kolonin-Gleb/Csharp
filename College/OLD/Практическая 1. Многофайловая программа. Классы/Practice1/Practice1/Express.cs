using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Express : Train
    {
        protected string route; // маршрут. Cтанции, на которых экспресс останавливается записаны в строку через запятую

        // 2. Конструктор класса - вызывает конструктор базового класса
        public Express(string _energySource, string _controlSystem, DateTime _productionDate, int _length, float _maxLoad,
            string _route) : base(_energySource, _controlSystem, _productionDate, _length, _maxLoad)
        {
            route = _route;
        }

        // 3. Свойства доступа к полям класса
        public string Route
        {
            get { return route; }
            set { route = value; }
        }

        // 4. Метод, который виводит значения полей класса
        public new void Print()
        {
            base.Print(); // вызов метода базового класса
            Console.WriteLine("route: {0}", route);
        }
    }
}
