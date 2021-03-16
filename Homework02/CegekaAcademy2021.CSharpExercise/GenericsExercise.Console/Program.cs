using System; 
namespace GenericsExercise.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            while(true)
            {
                DisplayMenu();
                int choice = Convert.ToInt32(System.Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        UniversityService.InsertUniversity(); 
                        break;
                    case 2:
                        StudentService.InsertStudent(); 
                        break;
                    case 3:
                        StudentService.DisplayAllStudents(); 
                        break;
                    case 4:
                        UniversityService.DisplayAllUniversities(); 
                        break;
                    case 5:
                        System.Environment.Exit(0);
                        break;                            
                    default:
                        System.Console.WriteLine("Alege o varianta care exista ");
                        break;
                }
            }


        }

        private static void DisplayMenu()
        {
            System.Console.WriteLine("1. Adaugati o universitate! ");
            System.Console.WriteLine("2. Adaugati un student! ");
            System.Console.WriteLine("3. Afisati toti studentii");
            System.Console.WriteLine("4. Afisati toate universitatile!");
            System.Console.WriteLine("5. Exit!");

        }
    }
}