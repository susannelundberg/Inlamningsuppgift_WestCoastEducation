namespace WCE.Domain;

public class TeacherRegisterd
{
    private readonly IList<Teacher> _teacher = new List<Teacher>();

    public void AddStudent(Teacher t)
    {
        _teacher.Add(t);
    }

    public void GetAllTeachers()
    {
        if (_teacher.Count == 0)
        {
            Console.WriteLine("Inga lärare är registrerade");
        }

        Console.WriteLine("Följande lärare är registrerade:");
        foreach (var student in _teacher)
        {
            Console.WriteLine(student);
        }
    }
}
