using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    public class Teacher : UniversityEmployee
    {
        public Course Course { get; set; }
        public Teacher(string person, int taxId, Course course)
        : base(person, taxId)

        {
          Course = course;
       }
        public override string GetOfficialDuties()
        {
           return "Specialization: " + Course.NameCourse + " Course: " + Course.CourseDescription;
        }
    }
}





//2.Создать класс Teacher (наследник UniversityEmployee), содержащий поле
//Course- курс, который обеспечивается данным преподавателем
//7.Переопределить метод GetOfficialDuties для всех наследников, в частности, для Teacher выводить список курсов,
//на которых он специлизируется 