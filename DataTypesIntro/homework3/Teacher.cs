namespace homework3;

internal class Teacher : UniversityEmployee
{
    public Course Course { get; set; }
    public Teacher(Person person, int taxId, Course course) : base(person, taxId, "")

    {
      Profession = "Teacher";
      Course = course;
   }
    public override string GetOfficialDuties()
    {
       return $"Specialization: { Course.NameCourse} Course: {Course.CourseDescription}";
    }
}





//2.Создать класс Teacher (наследник UniversityEmployee), содержащий поле
//Course- курс, который обеспечивается данным преподавателем
//7.Переопределить метод GetOfficialDuties для всех наследников, в частности, для Teacher выводить список курсов,
//на которых он специлизируется 