namespace homework3;

internal abstract class UniversityEmployee: IComparable<UniversityEmployee>
{
    public Person Person { get; set; }
    public string Profession { get; set; }
    public int TaxId { get; set; }
    public UniversityEmployee(Person person, int taxId, string profession)
    {   
        if (person.FirstName.Length + person.LastName.Length > 20) 
        {
            throw new ArgumentException("Full name length > 20");
        }
        Person = person;
        Profession = profession;
        if (taxId < 0)
        {
            throw new ArgumentException("Incorrect taxId");
        }
        TaxId = taxId;
    }
    public abstract string GetOfficialDuties();

    public override bool Equals(object? obj)
    {
        if (obj != null && obj is UniversityEmployee employee)
        {
            return TaxId == employee.TaxId;
        }   
            return false;
    }

    public override int GetHashCode()
    {
        return TaxId.GetHashCode();
    }

    public int CompareTo(UniversityEmployee x)
    {
        if (x == null)
        {
            return 1;
        }

        return Comparer<int>.Default.Compare((this.Person.SummaryNameLength()), (x.Person.SummaryNameLength()));
    }
}


//1. Создать класс UniversityEmployee, включающий поле типа Person и поле TaxID 
//6. В классе UniversityEmployee определить виртуальный метод GetOfficialDuties(),
//возвращающий строковое описание обязанностей  и возможностей сотрудника
