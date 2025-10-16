namespace WCE.Domain;

public class Administrator : EducationLeader
{
    
    public Administrator(
        string firstName,
        string lastName,
        string personalNumber,
        string phoneNumber,
        Address address,
        string knowledgeArea,
        IList<string> responsibleCourses,
        string dateOfEmployment
        ) : base(firstName, lastName, personalNumber, phoneNumber, address, knowledgeArea, responsibleCourses, dateOfEmployment)
    {}

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
        return $"Administratör | {FirstName} {LastName}, Personnummer: {PersonalNumber}, Telefonnummer: {PhoneNumber}, Adress: {Address}, Anställningsdatum: {DateOfEmployment}, Kunskapsområde: {KnowledgeArea}, Ansvariga kurser: {text}";
    }
}
