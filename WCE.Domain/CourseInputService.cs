namespace WCE.Domain;

public class CourseInputService
{
    private readonly List<Course> _courses = new();
    public Course ReadCourseFromConsole()
    {    
        Console.WriteLine("Ange kursnummer: ");
        string? courseNumber = Console.ReadLine();
        Console.WriteLine("Ange kursens namn: ");
        string? courseTitle = Console.ReadLine();
        Console.WriteLine("Ange antal studieveckor: ");
        string? courseLength = Console.ReadLine();
        Console.WriteLine("Ange startdatum (YYYY-MM-DD): ");
        string? courseStartDate = Console.ReadLine();
        Console.WriteLine("Ange slutdatum (YYYY-MM-DD): ");
        string? courseEndDate = Console.ReadLine();
        Console.WriteLine("Är det en distanskurd? J/N");
        string? distance = Console.ReadLine();
        while (distance != "J" && distance != "j" && distance != "N" && distance != "n")
        {
            Console.WriteLine("Fel svar angivet.");
            Console.WriteLine("Är det en distanskurd? J/N");
            distance = Console.ReadLine();
        }

        Course course = new Course(courseNumber, courseTitle, courseLength, courseStartDate, courseEndDate, distance);
        _courses.Add(course);

        var courses = Storage.ReadCoursesJson($"{Environment.CurrentDirectory}/data/courseInfo.json");
        courses.Add(course);
        Storage.WriteCoursesJson($"{Environment.CurrentDirectory}/data/courseInfo.json", courses);

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"Nu är {courseTitle} ({courseNumber}) registrerad som kurs!");
        Console.ResetColor();

        return course;
    }
}
