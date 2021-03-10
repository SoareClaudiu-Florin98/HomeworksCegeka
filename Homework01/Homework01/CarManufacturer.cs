using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Homework01
{
    static class CarManufacturer
    {
        private static List<Car> cars = new List<Car>();
        public static PackageType  getPackageType()
        {
            DiplayPackageOptions();
            int numberOfPackageType = Convert.ToInt32(Console.ReadLine());
            PackageType packageType;
            switch (numberOfPackageType)
            {
                case 1:
                    packageType = PackageType.EntryPackage;
                    break;
                case 2:
                    packageType = PackageType.Plus;
                    break;
                case 3:
                    packageType = PackageType.Premium;
                    break;
                default:
                    packageType = PackageType.EntryPackage;
                    break;
            }
            return packageType;
        }
        private static void DiplayPackageOptions()
        {
            Console.WriteLine("Alegeti un pachet: ");
            Console.WriteLine("1. EntryPackage");
            Console.WriteLine("2. Plus");
            Console.WriteLine("3. Premium");
        }
        public static void  AddCar()
        {
            Console.WriteLine(" Model: ");
            String model = Console.ReadLine();                         
            Car car = new Car(model,getPackageType()); 
            cars.Add(car);
        }
        public static void DisplayAllCars()
        {
            foreach(Car car in cars)
            {
                Console.WriteLine(car.ToString()); 
            }
        }
        public static void AddOptions()
        {
            PackageType packageType = getPackageType();
            Console.WriteLine("Ce optiuni vreti sa adaugati acestui model ?");
            String options = Console.ReadLine(); 
            foreach(Car car in cars)
            {
                if(car.CarPackageType == packageType)
                {
                    car.PackageOptions += options += " ";
                }
            }
            
        }
        public  static  int  NumberOfCreatedCars
        {
            get
            {
                return cars.Count;
            } 
        }
        public static void DeleteAllOptions()
        {
            foreach(Car car in cars)
            {
                car.PackageOptions = ""; 
            }
        }

        private  static Car GetCarByModel(String model )
        {
            foreach(Car car in cars)
            {
                if (car.CarModel == model) 
                {
                    return car; 
                }
            }
            return null; 
        }
        public static void DisplayCarByModel()
        {
            Console.WriteLine("Alege un model: ");
            String model = Console.ReadLine();
            Car car =GetCarByModel(model);
            if (car != null)
            {
                Console.WriteLine(car.ToString());

            }
        }       
    }
}
