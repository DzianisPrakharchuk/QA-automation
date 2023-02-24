using homework3;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityUnitTest
{
    [TestClass]
    public class TeacherUniTest
    {
        public static Adress adress = new Adress("Minsk", "Ignatovskogo", 2, 5);
        [TestMethod]
        public void CheckGetOfficialDutiesPositive()
        {
            var course = new Course("Byology", "Theory");
            var teacher = new Teacher(new Person("Ivan", "Golovko ", adress), 2134, course);

            Assert.AreEqual(teacher.GetOfficialDuties(), "Specialization: Byology Course: Theory");
        }
    }
}
