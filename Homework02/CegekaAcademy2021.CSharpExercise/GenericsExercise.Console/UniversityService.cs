using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExercise.Console
{
    class UniversityService
    {

        private static Persistence persistence = new Persistence();
        public static void InsertUniversity()
        {

            University university = new University();
            System.Console.WriteLine("Alege un id pentru student : ");
            university.Id = System.Console.ReadLine();
            System.Console.WriteLine("Alege un nume pentru universitate : "); 
            university.Name = System.Console.ReadLine();
            System.Console.WriteLine("Alege o adresa pentru universitate : ");
            university.Address = System.Console.ReadLine();
            persistence.InsertAsync(university);
        }

        public  static void DisplayAllUniversities()
        {
            DisplayToConsoleService.DisplayToConsole<University>(persistence); 


        }

    }
}
