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



        //    //Arrange
        //    var modeltest = new Car();
        //    //modeltest.model = "Toyota";
        //    modeltest.Model = ToString(); //sætter den til nul for at teste
        //    //Act
        //    string model = modeltest.Model;

        //    //Assert
        //    Assert.AreEqual("Toyota", model);
        //}

        /// <summary>
        /// Jeg har sat doors til at være over 5, hvilket gør at exception bliver smidt
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(IllegalDoorsException))]
        public void CarDoorTest()
        {
            var doorstest = new Car("toyota", 6, "1234ACS");
        }

        /// <summary>
        /// Jeg har sat doors til at være over 5, hvilket gør at exception bliver smidt
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CarModelTest()
        {
            var modeltest = new Car("", 3, "1234ACS");
        }

        /// <summary>
        /// Jeg har sat doors til at være over 5, hvilket gør at exception bliver smidt
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(SpecificCharactertException))]
        public void CarRegNoTest()
        {
            var regnotest = new Car("Toyota", 3, "123num");
        }

        
    }
}