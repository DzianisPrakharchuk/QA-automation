
namespace homework3;

public class SupportStaff :  UniversityEmployee
{
    public SupportStaff(Person person, int taxId, string profession) : base(person, taxId, profession)
    {
        Profession = profession;
    }
    public override string GetOfficialDuties()
    {
        return $"Profession: {Profession}";
    }
}
//Создать класс SupportStaff- наследник от UniversityEmployee, включающий
//с информацией о должностных обязанностях - охранник, уборщик, водитель и т.д.