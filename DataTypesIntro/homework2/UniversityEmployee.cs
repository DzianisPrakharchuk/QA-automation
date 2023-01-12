namespace homework2
{ 

public abstract class UniversityEmployee
{
    public string Person { get; set; }
    public int TaxId { get; set; }
        public UniversityEmployee(string person, int taxId)
        {

            Person = person;
            TaxId = taxId;
        }
        public abstract string GetOfficialDuties();
    }
}


//1. Создать класс UniversityEmployee, включающий поле типа Person и поле TaxID 
//6. В классе UniversityEmployee определить виртуальный метод GetOfficialDuties(),
//возвращающий строковое описание обязанностей  и возможностей сотрудника
