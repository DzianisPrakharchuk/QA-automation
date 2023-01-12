using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    public class DegreeTeacher : Teacher
    {
        public string ScienceDegree { get; set; }
        public string Rank  { get; set; }
        public DegreeTeacher(string person, int taxId, Course course, string scienceDegree, string rank)
            : base(person, taxId, course)
        {
            Rank = rank;
            ScienceDegree = scienceDegree;
        }
        public override string GetOfficialDuties()
        {
            return "Specialization: " + Course.NameCourse + " Course: " + Course.CourseDescription + " Rank: " + Rank + " Science degree: " + ScienceDegree;
        }
    }
}

//4.Создать класс DegreeTeacher- преподаватель со степенью, наследник от Teacher,
//содержащий поля с информацией о научной степени и звании преподавателя 