using BeadandoFeladat2021.MainPrograms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeadTest.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void FizzBuzzTest_DivideableByThree()
        {
            //Arrange
            int num3 = 3, num21 = 21;
            string actual3, actual21, expected = "Fizz";
            FizzBuzz fb = new FizzBuzz();
            //Act
            actual3 = fb.GetOutput(num3);
            actual21 = fb.GetOutput(num21);
            //Assert
            Assert.AreEqual(actual3, expected);
            Assert.AreEqual(actual21, expected);
        }

        [TestMethod]
        public void FizzBuzzTest_DivideableByFive()
        {
            //Arrange
            int num5 = 5, num25 = 25;
            string actual5, actual25, expected = "Buzz";
            FizzBuzz fb = new FizzBuzz();
            //Act
            actual5 = fb.GetOutput(num5);
            actual25 = fb.GetOutput(num25);
            //Assert
            Assert.AreEqual(actual5, expected);
            Assert.AreEqual(actual25, expected);
        }

        [TestMethod]
        public void FizzBuzzTest_DivideableByBoth()
        {
            //Arrange
            int num15 = 15, num120 = 120;
            string actual15, actual120, expected = "FizzBuzz";
            FizzBuzz fb = new FizzBuzz();
            //Act
            actual15 = fb.GetOutput(num15);
            actual120 = fb.GetOutput(num120);
            //Assert
            Assert.AreEqual(actual15, expected);
            Assert.AreEqual(actual120, expected);
        }

        [TestMethod]
        public void FizzBuzzTest_DivideableByNeither()
        {
            //Arrange
            int num44 = 44, num1002 = 1001;
            string actual44, actual1002, expected44 = num44.ToString(), expected1002 = num1002.ToString();
            FizzBuzz fb = new FizzBuzz();
            //Act
            actual44 = fb.GetOutput(num44);
            actual1002 = fb.GetOutput(num1002);
            //Assert
            Assert.AreEqual(actual44, expected44);
            Assert.AreEqual(actual1002, expected1002);
        }


    }
}
