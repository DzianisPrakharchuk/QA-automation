using homework3;


namespace UnivercityUnitTest
{
    [TestClass]
    public class UniversityEmployeeUnitTest
    {
        public static Adress persAdress = new("Minsk", "Dolgobrodskaya", 22, 78);
        public static Course persCourse = new("Literature", "Intro");
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckTaxIdNegative()
        {
            var teacher1 = new Teacher(new Person("Denis", "Prohorchuk", persAdress), -1111 ,persCourse);
        }

        [TestMethod]
        public void CheckTaxIdMathPositive() 
        {
            var teacher1 = new Teacher(new Person("Denis", "Prohorchuk", persAdress), 12, persCourse);
            var teacher2 = new Teacher(new Person("Victor", "Ahramchuk", persAdress), 12, persCourse);

            Assert.IsTrue(teacher1.Equals(teacher2));
        }

        [TestMethod]
        public void CheckTaxIdMathNegative()
        {
            var teacher1 = new Teacher(new Person("Denis", "Prohorchuk", persAdress), 11, persCourse);
            var teacher2 = new Teacher(new Person("Victor", "Ahramchuk", persAdress), 12, persCourse);

            Assert.IsFalse(teacher1.Equals(teacher2));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckSummaryNameLengthNegative()
        {
            var teacher1 = new Teacher(new Person("Denissssssssssss", "Prohorchukkkkkkkkk", persAdress), 11, persCourse);

        }

        [TestMethod]
        public void CheckCompareSummaryNameLengthPositive()
        {

        }

        [TestMethod]
        public void CompareToPositive() 
        {
            var teacher1 = new Teacher(new Person("Denis", "Prohorchuk", persAdress), 11, persCourse);
            var teacher2 = new Teacher(new Person("Denis", "Prohorchuk", persAdress), 11, persCourse);
            Assert.AreEqual(0, teacher1.CompareTo(teacher2));
            Assert.AreEqual(teacher1.GetHashCode(), teacher2.GetHashCode());
            
        }

        [TestMethod]
        public void CompareToPositive2()
        {
            var teacher1 = new Teacher(new Person("Denis", "Prohorchuk", persAdress), 11, persCourse);
            var teacher2 = new Teacher(new Person("Denis", "Prohor", persAdress), 11, persCourse);
            Assert.IsTrue(teacher1.CompareTo(teacher2) > 0);
           
        }

        [TestMethod]
        public void CompareToPositive3()
        {
            var teacher1 = new Teacher(new Person("Denis", "Prohor", persAdress), 11, persCourse);
            var teacher2 = new Teacher(new Person("Denis", "Prohorchuk", persAdress), 11, persCourse);
            Assert.IsTrue(teacher1.CompareTo(teacher2) < 0);

        }

    }
}
