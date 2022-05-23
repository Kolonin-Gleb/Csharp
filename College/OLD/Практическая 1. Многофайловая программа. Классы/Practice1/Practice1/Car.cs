using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    sealed class Car : TransportationDevice // Запечатанный класс = от него нельзя наследоваться
    {
        // 1. Внутренние поля класса
        protected string category; // категория
        protected string brand; // марка

        // 2. Конструктор класса - вызывает конструктор базового класса
        
        public Car(string _energySource, string _controlSystem, DateTime _productionDate,
            string _category, string _brand) : base(_energySource, _controlSystem, _productionDate)
        {
            category = _category;
            brand = _brand;
        }

        // 3. Свойства доступа к полям класса
        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        // 4. Метод, который виводит значения полей класса
        public new void Print()
        {
            base.Print(); // вызов метода базового класса
            Console.WriteLine("category: {0}", category);
            Console.WriteLine("brand: {0}", brand);
        }
    }
}
