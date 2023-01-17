namespace homework3;

internal class University
{
    public SupportStaff Rector { get; set; }
    public UniversityEmployee[] Employees { get; set; }
    public Building[] Buildings { get; set; }
    public AdressBuilding OfficialAdress { get; set; }
    public University(
        SupportStaff rector, 
        UniversityEmployee[] employees, 
        Building[] buildings, 
        AdressBuilding officialAdress)
    {
        this.Rector = rector;
        this.Employees = employees;
        this.Buildings = buildings;
        this.OfficialAdress = officialAdress;

    }
}


//1.Создать класс University , включающий массив сотрудников, ректора,
//и массив зданий (с адресами и помещениями внутри них)
