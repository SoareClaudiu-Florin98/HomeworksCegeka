using System;
using System.Collections.Generic;
using System.Text;

namespace Homework01
{
    class Car
    {
        private String carModel;
        private PackageType packageType;

        public Car(String carModel, PackageType packageType)
        {
            this.carModel = carModel;
            this.packageType = packageType;          
        }
        

        public String CarModel
        {
            get
            {
                return carModel; 
            }
            set
            {
                carModel = value; 
            }
        }
        public PackageType CarPackageType
        {
            get
            {
                return packageType; 
            }
            set
            {
                packageType = value; 
            }

        }
        public override string ToString()
        {
            return "Model " + this.carModel + " \n" + "Package: " + this.packageType + " \n"; 
        }


    }
}
