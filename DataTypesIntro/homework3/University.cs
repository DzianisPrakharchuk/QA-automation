namespace homework3;

internal class University
{
    public SupportStaff Rector { get; set; }
    public List<UniversityEmployee> Employees { get; private set; }
    public List<Building> Buildings { get; set; }
    public AdressBuilding OfficialAdress { get; set; }
    public University(
        SupportStaff rector, 
        List<UniversityEmployee> employees,
        List<Building> buildings, 
        AdressBuilding officialAdress)
    {
        this.Rector = rector;
        this.Employees = employees;
        this.Buildings = buildings;
        this.OfficialAdress = officialAdress;

    }
    public bool AddBuilding(Building building)
    {
        foreach (var Building in Buildings)
        {
            if (building.Equals(Building))
            {
                return false;
            }
            Buildings.Add(building);
        }
        return true;
    }

    public bool AddEmployee(UniversityEmployee employee)
    {
        foreach (var UniversityEmployee in Employees)
        {
            if (employee.Equals(UniversityEmployee))
            {
                return false;
            }
            Employees.Add(employee);
        }
            return true;
    }
    public override bool Equals(object? obj)
    {
        if (obj != null && obj is University university)
        {
            return Rector == university.Rector
                && Employees == university.Employees
                && Buildings == university.Buildings
                && OfficialAdress == university.OfficialAdress;
        }
        return false;

    }

    public override int GetHashCode()
    {
        return Rector.GetHashCode() + Employees.GetHashCode() + Buildings.GetHashCode() + OfficialAdress.GetHashCode();
    }
}



//1.Создать класс University , включающий массив сотрудников, ректора,
//и массив зданий (с адресами и помещениями внутри них)
//homework 4:
//перейти к использованию  List
//в классе University сделать publuc метод AddEmployee, который проходит по списку сотрудников и сранивает их
//с новым кандидатом при помощи Equals.
//Если сотрудник с таким TaxId не найден, добавляет его в список. 