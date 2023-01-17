namespace homework3;

internal abstract class UniversityEmployee
{
    public Person Person { get; set; }
    public string Profession { get; set; }
    public int TaxId { get; set; }
    public UniversityEmployee(Person person, int taxId, string profession)
    {
        Person = person;
        Profession = profession;
        TaxId = taxId;
    }
    public abstract string GetOfficialDuties();
}


//1. Создать класс UniversityEmployee, включающий поле типа Person и поле TaxID 
//6. В классе UniversityEmployee определить виртуальный метод GetOfficialDuties(),
//возвращающий строковое описание обязанностей  и возможностей сотрудника
