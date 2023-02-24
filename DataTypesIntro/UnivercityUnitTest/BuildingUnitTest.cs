using homework3;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityUnitTest
{
    [TestClass]
    public class BuildingTest
    {
        public static List<Room> rooms = new List<Room>();
        public static AdressBuilding adressBuilding = new AdressBuilding("Minsk", "Ignatovskogo", 2);


        [TestMethod]
        public void CheckAdresesEqualsPositive()
        {
            var adressBuilding = new AdressBuilding("Minsk", "Matusevicha", 22);
            var adressBuilding1 = new AdressBuilding("Minsk", "Matusevicha", 22);

            Assert.IsTrue(adressBuilding.Equals(adressBuilding1));
            Assert.AreEqual(adressBuilding.GetHashCode(), adressBuilding1.GetHashCode());
        }
        [TestMethod]
        public void CheckAdresesEqualsNegative()
        {
            var adressBuilding = new AdressBuilding("Minsk", "Matusevicha", 27);
            var adressBuilding1 = new AdressBuilding("Minsk", "Matusevicha", 22);

            Assert.IsFalse(adressBuilding.Equals(adressBuilding1));
        }

        [TestMethod]
        public void CheckIdNumberPositive()
        {
            var building = new Building(rooms, adressBuilding, 1223);
            var building1 = new Building(rooms, adressBuilding, 1223);

            Assert.IsTrue(building.Equals(building1));
            Assert.AreEqual(building.GetHashCode(), building1.GetHashCode());

        }

        [TestMethod]
        public void CheckIdNumberNegative()
        {
            var building = new Building(rooms, adressBuilding, 1223);
            var building1 = new Building(rooms, adressBuilding, 1023);

            Assert.IsFalse(building.Equals(building1));

        }
        [TestMethod]
        public void CheckAddRoomPositive()
        {
            var room = new Room(123, "Lection hall");
            var rooms = new List<Room> { room };
            var building = new Building(rooms, adressBuilding, 1223);

            Assert.IsFalse(building.AddRoom(room));
            Assert.AreEqual(building.Rooms.Count, 1);
        }

    }
}
