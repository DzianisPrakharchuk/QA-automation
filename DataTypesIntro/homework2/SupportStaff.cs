using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    internal class SupportStaff :  UniversityEmployee
    {
        public string Profession  { get; set; }
        public SupportStaff(string person, int taxId, string profession)
            : base(person, taxId)
        {
            Profession = profession;
        }
        public override string GetOfficialDuties()
        {
            return "Profession: " + Profession;
        }
    }
}
//Создать класс SupportStaff- наследник от UniversityEmployee, включающий
//с информацией о должностных обязанностях - охранник, уборщик, водитель и т.д.