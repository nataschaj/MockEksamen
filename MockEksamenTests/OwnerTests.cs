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
        /// <summary>
        /// Jeg har sat name til under 4 tegn, hvilket gør at exception bliver smidt
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(CharacterTooShortException))]
        public void OwnerNameTest()
        {
            var nametest = new Owner("fuldbrovej", "tas", "12345678");
        }

        /// <summary>
        /// Jeg har sat adress til under 6 tegn, hvilket gør at exception bliver smidt
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(CharacterTooShortException))]
        public void OwnerAdressTest()
        {
            var adresstest = new Owner("bro", "natascha", "12345678");
        }

        /// <summary>
        /// Jeg har sat phone til ikke at være 8, hvilket gør at exception bliver smidt
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(SpecificCharactertException))]
        public void OwnerPhoneTest()
        {
            var adresstest = new Owner("brovej", "natascha", "123");
        }

    }
}