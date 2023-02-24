using homework3;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityUnitTest
{
    [TestClass]
    public class SupportStaffUniTest
    {
        public static Adress adress = new Adress("Minsk", "Ignatovskogo", 2, 5);
        [TestMethod]
        public void CheckGetOfficialDutiesPositive()
        {
            
            var plumber = new SupportStaff(new Person("Ivan", "Golovko ", adress), 2134, "plumber");

            Assert.AreEqual(plumber.GetOfficialDuties(), "Profession: plumber");
        }
    }
}
