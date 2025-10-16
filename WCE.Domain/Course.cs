namespace WCE.Domain;

public class Course
{
    public string? CourseNumber { get; set; }
    public string? CourseTitle { get; set; }
    public string? CourseLength { get; set; }
    public string? CourseStartDate { get; set; }
    public string? CourseEndDate { get; set; }
    public Boolean Distance { get; set; }
    
    public Course(string? courseNumber, string? courseTitle, string? courseLength, string? courseStartDate, string? courseEndDate, string? distance)
    {
        CourseNumber = courseNumber;
        CourseTitle = courseTitle;
        CourseLength = courseLength;
        CourseStartDate = courseStartDate;
        CourseEndDate = courseEndDate;
        if (distance == "J" || distance == "j")
        {
            Distance = true;
        }
        else { Distance = false; }
    }
    public Course(){}
    public override string ToString()
    {
        return $"{CourseTitle} ({CourseNumber}), {CourseLength} veckor. Start: {CourseStartDate} - Slut: {CourseEndDate} - {OnsiteDistance()}";
    }
    public string OnsiteDistance() => Distance ? "Distanskurs" : "Kurs på plats";

}
