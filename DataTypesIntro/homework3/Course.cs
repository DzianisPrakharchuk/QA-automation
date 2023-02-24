
using System.Xml.Linq;

namespace homework3;

public class Course
{
    public string NameCourse { get; set; }
    public string CourseDescription { get; set; }
    public Course(string nameCourse, string courseDescription)
    {
        NameCourse = nameCourse;
        CourseDescription = courseDescription;
    }

    public override bool Equals(object? obj)
    {
        return obj is Course x && NameCourse == x.NameCourse && CourseDescription == x.CourseDescription;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(NameCourse, CourseDescription);
    }

}

//3.Создать класс Course- включает название и описание курса
