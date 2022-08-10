using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethod.metod
{
    public class Car:vehicle
    {
        public string Brand;
        public string Model;
        public double FuelCapacity;
        public int  CurrentFuel;
        public double FuelFor1km;

        public Car()
        {

        }
        public Car(int year, string colour, string Brand, string Model, double FuelCapacity, int CurrentFuel, double FuelFor1km) : base(colour,year)
        {

        }
        public void ShowStatus()
        {
            Console.WriteLine($"{ colour} { year} { Brand} {Model} {FuelCapacity} {FuelFor1km} {CurrentFuel}");
        }
        double fuel = 68;
        double distance = 200;
        double fuelfor1km = 0.06;
        public static double Drive(double distance,double fuelfor1km)
        {
            double fuel = 68;
            if (fuel>0)
            {
                fuel -= distance * fuelfor1km;
            }
            return fuel;
        }
      
    }
}
