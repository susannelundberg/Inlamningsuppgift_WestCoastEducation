namespace WCE.Domain;

public class StudentInputService
{

    private readonly List<Student> _student = new();
    public Student ReadStudentFromConsole()
    {
        Console.WriteLine("Ange förnamn: ");
        string? firstName = Console.ReadLine();
        Console.WriteLine("Ange efternamn: ");
        string? lastName = Console.ReadLine();
        Console.WriteLine("Ange personnummer: ");
        string? personalNumber = Console.ReadLine();
        Console.WriteLine("Ange telefonnummer: ");
        string? phoneNumber = Console.ReadLine();

        Console.WriteLine("Ange gatuadress: ");
        string? street = Console.ReadLine();
        Console.WriteLine("Ange postkod: ");
        string? postalCode = Console.ReadLine();
        Console.WriteLine("Ange ort: ");
        string? city = Console.ReadLine();

        Address address = new(street!, postalCode!, city!);
        Student student = new(firstName!, lastName!, personalNumber!, phoneNumber!, address);
        _student.Add(student);

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"Nu är {firstName} {lastName} registrerad som student!");
        Console.ResetColor();

        return student;
    }

}
