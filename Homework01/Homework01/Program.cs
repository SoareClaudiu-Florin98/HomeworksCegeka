using System;

namespace Homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                DisplayMenu();
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CarManufacturer.AddCar();
                        break;

                    case 2:
                        CarManufacturer.DisplayAllCars();
                        break;

                    case 3:
                        Console.WriteLine("Numarul total de masini fabricate:  " + CarManufacturer.NumberOfCreatedCars);
                        break;

                    case 4:
                        CarManufacturer.DisplayCarByModel();
                        break;

                    case 5:
                        CarManufacturer.AddOptions();
                        break;

                    case 6:
                        CarManufacturer.DeleteAllOptions();
                        break;

                    case 7:
                        System.Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Alege o varianta care exista ");
                        break;

                }
            }

        }

        private static void DisplayMenu()
        {
            Console.WriteLine(" 1. Adauga o noua masina");
            Console.WriteLine(" 2. Afiseaza toate masinile fabricate ");
            Console.WriteLine(" 3. Afiseaza numarul total de masini ");
            Console.WriteLine(" 4. Selecteaza masina dupa nume ");
            Console.WriteLine(" 5. Adauga optiuni la un pachet");
            Console.WriteLine(" 6. Sterge toate optiunile");
            Console.WriteLine(" 7. Exit");
        }
    }
}
