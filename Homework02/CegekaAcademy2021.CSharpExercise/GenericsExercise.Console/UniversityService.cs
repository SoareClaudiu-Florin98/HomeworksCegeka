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
            try
            {
                University university = new University();
                System.Console.WriteLine("Alege un id pentru student : ");
                university.Id = System.Console.ReadLine();
                if (university.Id == null || university.Id.Length <= 0)
                {
                    throw new Exception("Your ID should not be null!  ");
                }
                if (university.Id.Contains('%'))
                {
                    throw new Exception("Your ID should not contain the character % !");
                }
                if (university.Id.Length > 10)
                {
                    throw new Exception("Your ID should have max 10 characters!");
                }
                System.Console.WriteLine("Alege un nume pentru universitate : ");
                university.Name = System.Console.ReadLine();
                System.Console.WriteLine("Alege o adresa pentru universitate : ");
                university.Address = System.Console.ReadLine();
                persistence.InsertAsync(university);
            }
            catch(Exception ex)
            {
                System.Console.WriteLine(ex); 
            }
        }
        public  static void DisplayAllUniversities()
        {
            DisplayToConsoleService.DisplayToConsole<University>(persistence); 
        }

    }
}
