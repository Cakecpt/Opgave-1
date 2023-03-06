using Microsoft.VisualStudio.TestTools.UnitTesting;
using Car_opgave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_opgave.Tests
{
    [TestClass()]
    public class Car_MainTests
    {

        [TestMethod()]
        public void ValidateIDTest()
        {
            var id = new CarCreation();
            Assert.IsNotNull(id);
            
        }

        [TestMethod()]
        public void ValidateModelTest()
        {
            var model = new CarCreation();
            Assert.IsNotNull(model);
            Assert.AreNotEqual(model, 1);
        }

        [TestMethod()]
        public void ValidatePriceTest()
        {
            var price = new CarCreation();
            Assert.AreNotEqual(1, price);
        }

        [TestMethod()]
        public void ValidateLicensePlateTest()
        {
            var licensePlate = new CarCreation();
            Assert.AreNotEqual(7, licensePlate);
        }
    }
}