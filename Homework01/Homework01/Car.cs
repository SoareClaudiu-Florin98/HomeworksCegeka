using System;
using System.Collections.Generic;
using System.Text;

namespace Homework01
{
    class Car
    {
        private String carModel;
        private PackageType packageType;
        private String packageOptions;

        public Car(String carModel, PackageType packageType,String  packageOptions = "" )
        {
            this.carModel = carModel;
            this.packageType = packageType;
            this.packageOptions = packageOptions; 
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
        public String PackageOptions
        {
            get { return packageOptions;  }
            set
            {
                packageOptions = value; 

            }
        }
        public override string ToString()
        {
            return "Model " + this.carModel  + "  Package: " + this.packageType+"  Options: " +this.packageOptions + " \n "; 
        }


    }
}
