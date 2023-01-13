using System;


internal class University
{
    public Employee Rector { get; set; }
    public Employee[] Employees { get; set; }
    public Building[] Buildings { get; set; }
    public AdressBuilding OfficialAdress { get; set; }
    public University(Employee rector, Employee[] employees, Building[] buildings, AdressBuilding officialAdress)
    {
        this.Rector = rector;
        this.Employees = employees;
        this.Buildings = buildings;
        this.OfficialAdress = officialAdress;

    }
}


//1.Создать класс University , включающий массив сотрудников, ректора,
//и массив зданий (с адресами и помещениями внутри них)
