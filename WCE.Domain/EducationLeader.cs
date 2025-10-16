namespace WCE.Domain;

public class EducationLeader : Teacher
{
    public string? DateOfEmployment { get; set; }


    public EducationLeader(
        string firstName,
        string lastName,
        string personalNumber,
        string phoneNumber,
        Address address,
        string knowledgeArea,
        IList<string> responsibleCourses,
        string dateOfEmployment
        ) : base(firstName, lastName, personalNumber, phoneNumber, address, knowledgeArea, responsibleCourses)
    {
        DateOfEmployment = dateOfEmployment;
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
        return $"Utbildningsledare | {FirstName} {LastName}, Personnummer: {PersonalNumber}, Telefonnummer: {PhoneNumber}, Adress: { Address}, Anställningsdatum: {DateOfEmployment}, Kunskapsområde: {KnowledgeArea}, Ansvariga kurser: {text}";
    }
}