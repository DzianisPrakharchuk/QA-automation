using homework3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityUnitTest
{
    [TestClass]
    public class AdressTest
    {
        public static Adress personalAdress = new("Minsk", "Dolgobrodskaya", 22, 78);

        [TestMethod]
        public void CheckAdresesEqualsPositive()
        {
            Adress adress1 = personalAdress;
            Adress adress2 = personalAdress;

            Assert.AreEqual(adress1.GetHashCode(), adress2.GetHashCode());
            Assert.IsTrue(adress1.Equals(adress2));
        }

        [TestMethod]
        public void CheckAdresesEqualsNegative()
        {
            Adress adress1 = personalAdress;
            Adress adress2 = new Adress("Grodno", "Mira", 12, 27);

            Assert.IsFalse(adress1.Equals(adress2));
        }


        [TestMethod]
        public void CheckCityNameLengthPositive()
        {
            bool result = personalAdress.City.Length > 0 ? true : false;
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckCityNameLengthNegative()
        {
            var adress1 = new Adress("", "Ignatovskogo", 6, 78);
            Assert.IsFalse(adress1.City.Length > 0);
        }

        [TestMethod]
        public void CheckStreetNameLengthPositive()
        {
            bool result = personalAdress.Street.Length > 0 ? true : false;
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckStreetNameLengthNegative()
        {
            var adress1 = new Adress("Minsk", "", 6, 78);
            Assert.IsFalse(adress1.Street.Length > 0);
        }

        [TestMethod]     
        public void CheckMaxFlatNumberPositive()
        {
            var adress1 = new Adress("Minsk", "Ignatovskogo", 6, 800);

            Assert.AreEqual(800, adress1.FlatNumber);         
        }

        [TestMethod]
        public void CheckMaxFlatNumberNegative()
        {
            var adress1 = new Adress("Minsk", "Ignatovskogo", 6, 1010);
          
            Assert.AreEqual(0,adress1.FlatNumber);
        }

        [TestMethod]
        public void CheckMaxHouseNumberPositive()
        {
            var adress1 = new Adress("Minsk", "Ignatovskogo", 6, 10);

            Assert.AreEqual(6, adress1.HouseNumber);

        }

        [TestMethod]
        
        public void CheckMaxHouseNumberNegative()
        {
            var adress1 = new Adress("Minsk", "Ignatovskogo", 1010, 10);

            Assert.AreEqual(0, adress1.HouseNumber);
        }
    }
}
