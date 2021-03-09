using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Homework01
{
    static class CarManufacturer
    {
        private static List<Car> cars = new List<Car>();

        public static void  AddCar(Car car)
        {
            cars.Add(car);
        }
        public static int NumberOfCreatedCars()
        {
            return cars.Count; 
        }

        public static Car GetCarByModel(String model )
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
        

    }
}
