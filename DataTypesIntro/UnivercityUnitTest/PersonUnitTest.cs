using homework3;
using System;
using System.Collections.Generic;

namespace UniversityUnitTest
{
    [TestClass]
    public class PersonTest

    {
        public static Adress personalAdress = new("Minsk", "Dolgobrodskaya", 22, 78);
        public static Person p = new("Denis", "Ivanov", personalAdress);

        

        [TestMethod]
        public void CheckSummaryNameLength()
        {
          Assert.AreEqual(p.SummaryNameLength(), 11);
        }

        [TestMethod]
        public void CheckEqualsPersonsPositive()
        {
            var z = new Person("Sergey", "Petrov", personalAdress);
            var k = new Person("Sergey", "Petrov", personalAdress);
            Assert.AreEqual(z.GetHashCode(), k.GetHashCode());
            Assert.IsTrue(z.Equals(k));
        }

        [TestMethod]
        public void CheckEqualsPersonsNegative()
        {
            Person s = null;
            var k = personalAdress;
            var n = new Person("Stepan", "Petrov", personalAdress);
            Assert.IsFalse(n.Equals(p));
            Assert.IsFalse(n.Equals(k));
            Assert.IsFalse(n.Equals(s));
        }

        
    }
}