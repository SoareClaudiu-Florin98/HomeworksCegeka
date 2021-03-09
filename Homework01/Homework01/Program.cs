using System;

namespace Homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CarManufacturer.AddCar(new Car("Mercedes", PackageType.EntryPackage));
            CarManufacturer.AddCar(new Car("Skoda", PackageType.Premium));
            CarManufacturer.AddCar(new Car("Logan", PackageType.Plus));
            Console.WriteLine(CarManufacturer.GetCarByModel("Logan").ToString()); 
            Console.WriteLine(CarManufacturer.NumberOfCreatedCars()); 
        }
    }
}
