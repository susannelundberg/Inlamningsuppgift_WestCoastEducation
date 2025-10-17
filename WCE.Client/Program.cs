using System.Globalization;
using WCE.Domain;

namespace WCE.Client;

class Program
{
    static CourseRegisterd courseRegisterd = new();
    static StudentRegisterd studentRegisterd = new();
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("==========================================================");
        Console.WriteLine("Välkommen till Westcoast Education");
        Console.ResetColor();

        bool going = true;
        while (going)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==========================================================");
            Console.WriteLine("MENY");
            Console.WriteLine("Var god gör ett val");
            Console.WriteLine("==========================================================");
            Console.WriteLine("För att registrera en ny kurs tryck 1");
            Console.WriteLine("För att registrera en ny student tryck 2");
            Console.WriteLine("För att registrera en ny lärare tryck 3");
            Console.WriteLine("För att registrera en ny utbildningsledare tryck 4");
            Console.WriteLine("För att registrera en ny administratör tryck 5");
            Console.WriteLine("För att visa alla kurser tryck 6");
            Console.WriteLine("För att visa all studenter tryck 7");
            Console.WriteLine("För att avsluta tryck 8");
            Console.WriteLine("Var god gör ditt val:");
            Console.ResetColor();

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CourseInputService inputService = new();
                    Course newCourse = inputService.ReadCourseFromConsole();
                    courseRegisterd.AddCourse(newCourse);
                    break;

                case "2":
                    StudentInputService inputService1 = new();
                    Student newStudent = inputService1.ReadStudentFromConsole();
                    studentRegisterd.AddStudent(newStudent);
                    break;

                case "3":
                    break;

                case "4":
                    break;

                case "5":
                    break;

                case "6":
                    courseRegisterd.GetAllCourses();
                    break;

                case "7":
                    studentRegisterd.GetAllStudents();
                    break;

                case "8":
                    going = false;
                    break;

                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    Console.WriteLine("");
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine("==========================================================");
            Console.WriteLine("Vill du fortsätta? J/N");
            var key = Console.ReadLine();
            if (key == "J" || key == "j")
            {
                going = true;
            }
            else if (key == "N" || key == "n")
            {
                going = false;
            }
            else
            {
                Console.WriteLine("Ogiltigt val. Försök igen.");
                Console.WriteLine("");
            }
            // Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");

        }

    }

}
