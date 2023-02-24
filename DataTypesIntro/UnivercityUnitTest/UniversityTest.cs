using homework3;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityUnitTest
{
    [TestClass]
    public class UniversityTest
    {
        public static Adress adress = new("Minsk", "Dolgobrodskaya", 22, 78);
        public static Person p = new("Denis", "Ivanov", adress);
        public List<Building> buildings = new List<Building>();
        public List<UniversityEmployee> employee = new List<UniversityEmployee> ();
        

        [TestMethod]
        public void CheckAddBuilding()
        {
            var building1 = new Building(new List<Room>{ }, new AdressBuilding("Minsk", "Matusevicha", 24), 234);
            var building2 = new Building(new List<Room> { }, new AdressBuilding("Minsk", "Matusevicha", 25), 236);
            
            var university = new University(
                new SupportStaff(
                    new Person("Test", "Test", adress),
                    111, 
                    "rector"),
                employee,
                new List<Building> {building1},
                new AdressBuilding("", "", 1));

           //university.AddBuilding(building1);
            university.AddBuilding(building2);
            Assert.AreEqual(2, university.Buildings.Count);
        }

        [TestMethod]
        public void CheckAddEmployee() 
        {
            var krivoy = new
            SupportStaff(new Person("Anatoly", "Krivoy", new Adress("Zhodino", "Bedy", 11, 12)), 1156, "Plumber");
                        
            var university = new University(
                new SupportStaff(
                    new Person("", "", adress), 
                    111, 
                    "rector"),
                employee,
                buildings,
                new AdressBuilding("", "", 1));

            university.AddEmployee(krivoy);
                      
            Assert.IsTrue(university.Employees.Contains(krivoy));
        }
        [TestMethod]
        public void CheckUniversityEquals()
        {
            var e1 = new Teacher(
                new Person("Anatoly", "Krivoy", new Adress("Zhodino", "Bedy", 11, 12)),
                1156, new Course("",""));

            var e2 = new Teacher(
                new Person("Anatoly", "Rovny", new Adress("Zhodino", "Dobra", 10, 10)),
                1157, new Course("", ""));

            var e3 = new Teacher(
                new Person("Anatoly", "Korotky", new Adress("Zhodino", "Mira", 13, 13)),
                1158, new Course("", ""));

            List<UniversityEmployee> employees1 = new List<UniversityEmployee> { e1, e2 };
            List<UniversityEmployee> employees2 = new List<UniversityEmployee> { e1, e3 };
            var b1 = new Building(new List<Room> { }, new AdressBuilding("", "", 11), 1111);
            var b2 = new Building(new List<Room> { }, new AdressBuilding("", "", 12), 1112);
            var b3 = new Building(new List<Room> { }, new AdressBuilding("", "", 23), 1113);

            var university1 = new University(
                new SupportStaff(
                    new Person("Ivan", "Ivanov", adress),
                    111,
                    "rector"),
                employees1,
                new List<Building> {b1,b2},
                new AdressBuilding("Minsk", "NeKrasivaya", 1));


            var university2 = new University(
                new SupportStaff(
                    new Person("Ivan", "Ivanov", adress),
                    111,
                    "rector"),
                employees2,
                new List<Building> { b1, b3 },
                new AdressBuilding("Minsk", "Krasivaya", 1));

            Assert.IsFalse(university1.Equals(university2));
         
        }
    }
}
