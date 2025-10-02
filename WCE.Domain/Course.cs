namespace WCE.Domain;

public class Course
{
    public string? CourseNumber { get; set; }
    public string? CourseTitle { get; set; }
    public string? CourseLength { get; set; }
    public string? CourseStartDate { get; set; }
    public string? CourseEndtDate { get; set; }

    public Course(string? courseNumber, string? courseTitle, string? courseLength, string? courseStartDate, string? courseEndDate)
    {
        CourseNumber = courseNumber;
        CourseTitle = courseTitle;
        CourseLength = courseLength;
        CourseStartDate = courseStartDate;
        CourseEndtDate = courseEndDate;
    }

    public override string ToString()
    {
        return $"{CourseTitle} ({CourseNumber}), {CourseLength} veckor. Start: {CourseStartDate} - Slut: {CourseEndtDate}";
    }
}
