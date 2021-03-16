using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExercise.Console
{
    class StudentService
    {
        private static Persistence persistence = new Persistence();
        public static void InsertStudent()
        {
            try
            {
                Student student = new Student();
                System.Console.WriteLine("Alege un id pentru student : ");
                student.Id = System.Console.ReadLine();
                if (student.Id == null || student.Id.Length <= 0)
                {
                    throw new Exception("Your ID should not be null!  ");
                }
                if (student.Id.Contains('%'))
                {
                    throw new Exception("Your ID should not contain the character % !"); 
                }
                if (student.Id.Length>10)
                {
                    throw new Exception("Your ID should have max 10 characters!");
                }
                System.Console.WriteLine("Alege un prenume pentru student : ");
                student.FisrtName = System.Console.ReadLine();
                System.Console.WriteLine("Alege un nume pentru student : ");
                student.LastName = System.Console.ReadLine();
                persistence.InsertAsync(student);
            }

            catch(Exception ex)
            {
                System.Console.WriteLine(ex); 
            }
        }
        public   static void DisplayAllStudents()
        {
            DisplayToConsoleService.DisplayToConsole<Student>( persistence);
        }

    }
}
