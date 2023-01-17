namespace homework3;

internal class DegreeTeacher : Teacher
{
    public string ScienceDegree { get; set; }
    public string Rank  { get; set; }
    public DegreeTeacher(Person person, int taxId, Course course, string scienceDegree, string rank)
        : base(person, taxId, course)
    {
        Rank = rank;
        ScienceDegree = scienceDegree;
    }
    public override string GetOfficialDuties()
    {
        return $"Specialization: {Course.NameCourse} Course: {Course.CourseDescription} Rank: {Rank}  Science degree: {ScienceDegree}";
    }
}

//4.Создать класс DegreeTeacher- преподаватель со степенью, наследник от Teacher,
//содержащий поля с информацией о научной степени и звании преподавателя 