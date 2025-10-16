using System.Collections.Generic;
using System.Runtime.CompilerServices;
namespace WCE.Domain;

public class StudentRegisterd
{
    private readonly IList<Student> _students = new List<Student>();

    public void AddStudent(Student s)
    {
        _students.Add(s);
    }

    public void GetAllStudents()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        if (_students.Count == 0)
        {
            // Sätt färg
            Console.WriteLine("==========================================================");
            Console.WriteLine("Inga studenter är registrerade");
            Console.WriteLine("==========================================================");
        }
        else
        {
            Console.WriteLine("Följande studenter är registrerade:");
            foreach (var student in _students)
            {
                Console.WriteLine(student);
            }
        }
        Console.ResetColor();
    }

    
}
