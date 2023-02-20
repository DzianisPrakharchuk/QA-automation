
using System.IO;

namespace homework3;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Adress Adress { get; set; }

    public Person(string firstName, string lastName, Adress adress)
    {
        FirstName = firstName;
        LastName = lastName;
        Adress = adress;
    }
    public override bool Equals(object? obj)
    {
        if (obj != null && obj is Person person)
        {
            return FirstName == person.FirstName 
                && LastName == person.LastName 
                && Adress == person.Adress;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return FirstName.GetHashCode() + LastName.GetHashCode() + Adress.GetHashCode();
    }

    public int SummaryNameLength()
    {
        return FirstName.Length + LastName.Length;
    }
}
