using BeadandoFeladat2021.MainPrograms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeadTest.Tests
{
    [TestClass]
    public class LeapYearTests
    {
        [TestMethod]
        public void LeapYear_DivisibleWith100NotWith4()
        {
            //Arrange
            int year = 1700;
            bool actual;
            LeapYear ly = new LeapYear();
            //Act
            actual = ly.checkLeapYear(year);
            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void LeapYear_NotDivisibleWith4AndHundred1998()
        {
            //Arrange
            int year = 1998;
            bool actual;
            LeapYear ly = new LeapYear();
            //Act
            actual = ly.checkLeapYear(year);
            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void LeapYear_NotDivisibleWith4AndHundred1973()
        {
            //Arrange
            int year = 1973;
            bool actual;
            LeapYear ly = new LeapYear();
            //Act
            actual = ly.checkLeapYear(year);
            //Assert
            Assert.IsFalse(actual);
        }


        [TestMethod]
        public void LeapYear_NotDivisibleWith4AndHundred2014()
        {
            //Arrange
            int year = 2014;
            bool actual;
            LeapYear ly = new LeapYear();
            //Act
            actual = ly.checkLeapYear(year);
            //Assert
            Assert.IsFalse(actual);
        }
       
        
        [TestMethod]
        public void LeapYear_DivisibleWith4With100Not1664()
        {
            //Arrange
            int year = 1664;
            bool actual;
            LeapYear ly = new LeapYear();
            //Act
            actual = ly.checkLeapYear(year);
            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void LeapYear_DivisibleWith4With100Not1944() { 
            //Arrange
            int year = 1944;
            bool actual;
            LeapYear ly = new LeapYear();
            //Act
            actual = ly.checkLeapYear(year);
            //Assert
            Assert.IsTrue(actual);
        }


        [TestMethod]
        public void LeapYear_DivisibleWith4With100Not2012()
        {
            //Arrange
            int year = 2012;
            bool actual;
            LeapYear ly = new LeapYear();
            //Act
            actual = ly.checkLeapYear(year);
            //Assert
            Assert.IsTrue(actual);
        }
       
        [TestMethod]
        public void LeapYear_DivisibleBy400_1600() {
            //Arrange
            int year = 1600;
            bool actual;
            LeapYear ly = new LeapYear();
            //Act
            actual = ly.checkLeapYear(year);
            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void LeapYear_DivisibleBy400_2400()
        {
            //Arrange
            int year = 2400;
            bool actual;
            LeapYear ly = new LeapYear();
            //Act
            actual = ly.checkLeapYear(year);
            //Assert
            Assert.IsTrue(actual);
        }


        [TestMethod]
        public void LeapYear_DivisibleBy400_2000()
        {
            //Arrange
            int year = 2000;
            bool actual;
            LeapYear ly = new LeapYear();
            //Act
            actual = ly.checkLeapYear(year);
            //Assert
            Assert.IsTrue(actual);
        }
        
        [TestMethod]        
        public void LeapYear_YearZero() {
            //Arrange
            int year = 0;
            bool actual;
            LeapYear ly = new LeapYear();
            //Act
            //Assert
            Assert.ThrowsException<ArgumentException>(() =>ly.checkLeapYear(year));
        }

        [TestMethod]
        public void LeapYear_BeforeChristBC8()
        {
            //Arrange
            int year = -8;
            bool actual;
            LeapYear ly = new LeapYear();
            //Act
            //Assert
            Assert.ThrowsException<ArgumentException>(() => ly.checkLeapYear(year));
        }

        [TestMethod]
        public void LeapYear_BeforeGregorian1200()
        {
            //Arrange
            int year = 1200;
            bool actual;
            LeapYear ly = new LeapYear();
            //Act
            //Assert
            Assert.ThrowsException<ArgumentException>(() => ly.checkLeapYear(year));
        }

    }
}
