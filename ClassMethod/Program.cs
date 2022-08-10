using ClassMethod.metod;
using System;

namespace ClassMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car();
            bmw.year = 2022;
            bmw.colour = "black";
            bmw.Brand = "BMW";
            bmw.Model = "M8";
            bmw.FuelCapacity = 68;
            bmw.FuelFor1km = 0.06;
            bmw.CurrentFuel = 6;
            bmw.ShowStatus();
            double fuel = Car.Drive(200, 0.06);
            Console.WriteLine(fuel);
        }
    }
}
