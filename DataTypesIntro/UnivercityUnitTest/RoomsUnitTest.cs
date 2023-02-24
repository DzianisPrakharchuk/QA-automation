using homework3;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityUnitTest
{
    [TestClass]
    public class RoomsUnitTest
    {
        [TestMethod]
        public void CheckRoomsEqualNegative()
        {
            var room = new Room(1, "Class");
            var room1 = new Room(1, "Lection");
            Assert.AreNotEqual(room, room1);
        }

        [TestMethod]
        public void CheckRoomsEqualPositive() 
        {
            var room = new Room(12, "Class");
            var room1 = new Room(12, "Class");
            Assert.AreEqual(room, room1);
        }

        [TestMethod]
        public void CheckRoomNumberPositive()
        {
            var room = new Room(12, "Class");
            Assert.AreEqual(12, room.RoomNumber);
        }

        [TestMethod]
        public void CheckRoomNumberNegative1() 
        {
            var room = new Room(-12, "Class");
            Assert.AreEqual(0, room.RoomNumber);
        }

        [TestMethod]
        public void CheckRoomNumberNegative2()
        {
            var room = new Room(1010, "Class");
            Assert.AreEqual(0, room.RoomNumber);
        }

        

    }
}
