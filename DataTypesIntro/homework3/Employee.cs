using System;

public class Employee
{
    public string FirstName { get; set; }

    public string LastName { get; set; }
    public string Profession { get; set; }
    public int TaxId { get; set; }



    public Employee(string firstName, string lastName, string profession, int taxId)
    {
        FirstName = firstName;
        LastName = lastName;
        Profession = profession;
        TaxId = taxId;
    }
}
