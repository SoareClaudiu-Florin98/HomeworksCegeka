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

            Student student = new Student();
            System.Console.WriteLine("Alege un id pentru student : ");
            student.Id = System.Console.ReadLine(); 
            System.Console.WriteLine("Alege un prenume pentru student : ");
            student.FisrtName = System.Console.ReadLine();
            System.Console.WriteLine("Alege un nume pentru student : ");
            student.LastName = System.Console.ReadLine();
            persistence.InsertAsync(student);

        }
        public   static void DisplayAllStudents()
        {
            DisplayToConsoleService.DisplayToConsole<Student>( persistence);
        }

    }
}
