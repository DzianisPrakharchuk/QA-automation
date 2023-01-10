using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_Candidate
{
    internal class Person
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
    }
}
