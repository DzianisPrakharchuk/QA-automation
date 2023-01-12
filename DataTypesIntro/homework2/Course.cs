using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    public class Course
    {
        public string NameCourse { get; set; }
        public string CourseDescription { get; set; }
        public Course(string nameCourse, string courseDescription)
        {
            NameCourse = nameCourse;
            CourseDescription = courseDescription;
        }
    }
}

//3.Создать класс Course- включает название и описание курса
