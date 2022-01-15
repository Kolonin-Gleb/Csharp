using System;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая работа 1";

            Console.WriteLine("Использование экземпляра класса TransportationDevice");
            TransportationDevice ts = new TransportationDevice("gasoline", "steering wheel", Convert.ToDateTime("02.02.2020"));
            ts.Print();
            Console.WriteLine("\n");

            Console.WriteLine("Использование экземпляра класса Car");
            Car car = new Car("electricity", "autopilot", Convert.ToDateTime("01.01.2022"), "B1", "Tesla");
            car.Print();
            Console.WriteLine("\n");


            Console.WriteLine("Использование экземпляра класса Train");
            Train trainTT = new Train("coal", "rods", Convert.ToDateTime("01.01.2000"), 400, 10);
            trainTT.Print();
            Console.WriteLine("\n");

            // Использование экземпляра класса Train со свойствами класса Express

            Console.ReadKey();
        }
    }
}

