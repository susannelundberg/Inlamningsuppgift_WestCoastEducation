namespace WCE.Domain;

public class Teacher : Student
{
    public string? KnowledgeArea { get; set; }
    public IList<string> ResponsibleCourses { get; set; } = new List<string>();

    public Teacher(string firstName,
    string lastName,
    string personalNumber,
    string phoneNumber,
    Address address,
    string knowledgeArea,
    IList<string> responsibleCourses) : base(firstName, lastName, personalNumber, phoneNumber, address)
    {
        KnowledgeArea = knowledgeArea;
        ResponsibleCourses = responsibleCourses;
    }

    public override string ToString()
    {
        string text = "Inga kurser registrerade";
        if (ResponsibleCourses.Count > 0)
        {
            text = "";
            foreach (var course in ResponsibleCourses)
            {
                text += course + ", ";
            }
            text = text.TrimEnd(',', ' ');
        }
        return $"Lärare | {FirstName} {LastName}, Personnummer: {PersonalNumber}, Telefonnummer: {PhoneNumber}, Adress: {Address}, Kunskapsområde: {KnowledgeArea}, Ansvariga kurser: {text}";
    }
}
