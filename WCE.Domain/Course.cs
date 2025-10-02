namespace WCE.Domain;

public class Course
{
    public int CourseNumber { get; set; }
    public string? CourseTitle { get; set; }
    public int CourseLength { get; set; }
    public DateOnly CourseStartDate { get; set; }
    public DateOnly CourseEndtDate { get; set; }
}
