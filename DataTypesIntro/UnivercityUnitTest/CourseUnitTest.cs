using homework3;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityUnitTest
{
    [TestClass]
    public class CourseUnitTest
    {
        [TestMethod]
        public void CheckEqualhNameCourseAndDescriptionCourse()
        {
            var x = new Course("Math", "Introduction");

            var y = new Course("Math", "Introduction");

            Assert.IsTrue(x.Equals(y));
            Assert.AreEqual(x.GetHashCode(), y.GetHashCode());
        }

        [TestMethod]
        public void CheckMatchNameCourseAndDescriptionCourseNegative()
        {
            var x = new Course("Math", "Introduction");

            var y = new Course("Chemistry", "Introduction");

            Assert.IsFalse(x.Equals(y));
        }
        [TestMethod]
        public void CheckMatchNameCourseAndDescriptionCourseNegative2()
        {
            var x = new Course("Math", "Introduction");

            var y = new Course("Math", "Infinity");

            Assert.IsFalse(x.Equals(y));
        }

    }
}
