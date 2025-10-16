namespace WCE.Domain;

public class CourseRegisterd
{
    private readonly IList<Course> _courses = new List<Course>();

    public void AddCourse(Course c)
    {
        _courses.Add(c);
    }

    public void GetAllCourses()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        if (_courses.Count == 0)
        {
            Console.WriteLine("==========================================================");
            Console.WriteLine("Inga kurser är registrerade");
            Console.WriteLine("==========================================================");
        }
        else
        {
            Console.WriteLine("Följande kurser är registrerade:");
            foreach (var course in _courses)
            {
                Console.WriteLine(course);
            }
        }
        Console.ResetColor();
    }
}
