using System;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Profession { get; set; }
    private int _taxId;
    public int TaxId {
        get
        {
            return _taxId;
        }
        set
        {
            if (value > 0)
            {
                _taxId = value;
            }
        }
    }

    public Employee(
        string firstName, 
        string lastName, 
        string profession, 
        int taxId)
    {
        FirstName = firstName;
        LastName = lastName;
        Profession = profession;
        _taxId = taxId;
    }
}
