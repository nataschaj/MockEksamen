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
    public class OwnerTests
    {
        [TestMethod()]
        public void OwnerTest()
        {
            //Arrange
            var navn = new Owner();
            //Act
            string Name = navn.name;
            //Assert
            Assert.AreEqual("Natascha", Name);
        }
    }
}