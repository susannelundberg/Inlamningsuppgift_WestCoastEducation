namespace WCE.Domain;

public class Student
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? PersonalNumber { get; set; }
    public string? PhoneNumber { get; set; }
    public Address Address { get; set; } 

    public Student(string firstName, string lastName, string personalNumber, string? phoneNumber, Address address)
    {
        FirstName = firstName;
        LastName = lastName;
        PersonalNumber = personalNumber;
        PhoneNumber = phoneNumber;
        Address = address;
    }

    public override string ToString()
    {
        return $"Student | {FirstName} {LastName}, Personnummer: {PersonalNumber}, Telefonnummer: {PhoneNumber}, Adress: {Address}";
    }
}
