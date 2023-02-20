using System.Data;

namespace homework3;

internal abstract class UniversityEmployee: IComparable<UniversityEmployee>,IComparer<UniversityEmployee>
{
    public Person Person { get; set; }
    public string Profession { get; set; }
    private int _taxId;

    public int TaxId 
    {
        get
        {
            return _taxId;
        } 
        set {
            if (value < 0)
            {
                throw new ArgumentException("Incorrect taxId");
            }
            _taxId = value;
        }
    }
    public UniversityEmployee(Person person, int taxId, string profession)
    {
        if (person == null)
        {
            throw new ArgumentNullException(nameof(person));
        }
        if (person.FirstName.Length + person.LastName.Length > 20)
        {
            throw new ArgumentException("Full name length > 20");
        }
        Person = person;
        Profession = profession;
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

    public int CompareTo(UniversityEmployee? x)
    {
        if (x == null)
        {
            return 1;
        }

        return Person.SummaryNameLength() - x.Person.SummaryNameLength();
    }
    public int Compare(UniversityEmployee? x, UniversityEmployee? y)
    {
        return (x?.Person.SummaryNameLength() ?? 0) - (y?.Person.SummaryNameLength() ?? 0);
    }
}


//1. Создать класс UniversityEmployee, включающий поле типа Person и поле TaxID 
//6. В классе UniversityEmployee определить виртуальный метод GetOfficialDuties(),
//возвращающий строковое описание обязанностей  и возможностей сотрудника
