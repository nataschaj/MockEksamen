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
        /// Test som gerne bør fejl fordi model er sat til null og den som forventes er "toyota"
        /// </summary>
        [TestMethod()]
        //[ExpectedException(typeof(ArgumentNullException))]
        public void ModelTestNull()
        {
            
            //Arrange
            var modeltest = new Car();
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

        //    //Act
        //    int door = doortest.doors;
        //    //Assert
        //    Assert.AreEqual(2, door);
        //}

        //IGNORER 
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