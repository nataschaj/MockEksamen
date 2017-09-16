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

        /// <summary>
        /// Test som gerne bør vise grøn fordi model er sat til null og den som forventes er "toyota"
        /// grunden til at den viser grøn er fordi jeg forventer en exception
        /// Null exception kommer frem med at den ikke må sættes til nul.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))] //hvis dette fjernes vil testen vise rød
        public void ModelTestNull()
        {

            //Arrange
            var modeltest = new Car();
            //modeltest.model = "Toyota";
            modeltest.model = null; //sætter den til nul for at teste
            //Act
            string model = modeltest.model;

            //Assert
            Assert.AreEqual("Toyota", model);
        }




        //IGNORER
        //[TestMethod()]
        ////[ExpectedException(typeof(ArgumentNullException))]
        //public void DoorTest()
        //{
        //    //Arrange
        //    var doortest = new Car(); 
        //    doortest.doors = 1;

        //    //Act
        //    int door = doortest.doors;
        //    //Assert
        //    Assert.AreEqual(1, door);
        //}

        //[TestMethod()]
        //[ExpectedException(typeof(ArgumentNullException))]
        //public void ModelTest()
        //{
        //    //Arrange
        //    var modeltest = new Car();
        //    //Act
        //    string model = modeltest.model;
        //    //Assert
        //    Assert.AreEqual(3, model);
        //}
    }
}