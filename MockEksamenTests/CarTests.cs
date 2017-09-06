using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockEksamen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockEksamen.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void CarTest()
        {
            //Arrange
            var ccolor = new Car();
            //Act
            string Carcolor = ccolor.model;
            //Assert
            Assert.AreEqual(null, Carcolor);
        }
    }
}