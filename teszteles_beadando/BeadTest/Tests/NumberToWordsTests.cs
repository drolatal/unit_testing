using BeadandoFeladat2021.MainPrograms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeadTest.Tests
{
    [TestClass]
    public class NumberToWordsTests
    {
        #region Tests For Numbers From Zero To Twenty
        [TestMethod]
        public void ConvertNumbers_Zero() {
            //arrange
            int num = 0;
            string actual, expected = "zero";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_One()
        {
            //arrange
            int num = 1;
            string actual, expected = "one";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_Two()
        {
            //arrange
            int num = 2;
            string actual, expected = "two";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_Three()
        {
            //arrange
            int num = 3;
            string actual, expected = "three";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_Four()
        {
            //arrange
            int num = 4;
            string actual, expected = "four";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_Five()
        {
            //arrange
            int num = 5;
            string actual, expected = "five";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_Six()
        {
            //arrange
            int num = 6;
            string actual, expected = "six";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_Seven()
        {
            //arrange
            int num = 7;
            string actual, expected = "seven";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_Eight()
        {
            //arrange
            int num = 8;
            string actual, expected = "eight";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_Nine()
        {
            //arrange
            int num = 9;
            string actual, expected = "nine";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_Ten()
        {
            //arrange
            int num = 10;
            string actual, expected = "ten";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_Eleven()
        {
            //arrange
            int num = 11;
            string actual, expected = "eleven";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_Twelve()
        {
            //arrange
            int num = 12;
            string actual, expected = "twelve";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_Thirteen()
        {
            //arrange
            int num = 13;
            string actual, expected = "thirteen";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_Fourteen()
        {
            //arrange
            int num = 14;
            string actual, expected = "fourteen";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_Fifteen()
        {
            //arrange
            int num = 15;
            string actual, expected = "fifteen";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_Sixteen()
        {
            //arrange
            int num = 16;
            string actual, expected = "sixteen";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_Seventeen()
        {
            //arrange
            int num = 17;
            string actual, expected = "seventeen";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_Eighteen()
        {
            //arrange
            int num = 18;
            string actual, expected = "eighteen"; // így kell írni
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_Nineteen()
        {
            //arrange
            int num = 19;
            string actual, expected = "nineteen";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_Twenty()
        {
            //arrange
            int num = 20;
            string actual, expected = "twenty";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Tests For Tenth Numbers

        [TestMethod]
        public void ConvertNumbers_Thirty()
        {
            //arrange
            int num = 30;
            string actual, expected = "thirty";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_Forty()
        {
            //arrange
            int num = 40;
            string actual, expected = "forty";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_Fifty()
        {
            //arrange
            int num = 50;
            string actual, expected = "fifty";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_Sixty()
        {
            //arrange
            int num = 60;
            string actual, expected = "sixty";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_Seventy()
        {
            //arrange
            int num = 70;
            string actual, expected = "seventy";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_Eighty()
        {
            //arrange
            int num = 80;
            string actual, expected = "eighty";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_Ninety()
        {
            //arrange
            int num = 90;
            string actual, expected = "ninety";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Tests For Hundreds
        //nem tesztelem végig minden százasra, mert az elején leteszteltük, hogy 0-20 a számokat rendesen kiírja
        [TestMethod]
        public void ConvertNumbers_OneHundred()
        {
            //arrange
            int num = 100;
            string actual, expected = "one hundred ";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_TwoHundred()
        {
            //arrange
            int num = 200;
            string actual, expected = "two hundred ";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_FiveHundred()
        {
            //arrange
            int num = 500;
            string actual, expected = "five hundred ";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_NineHundred()
        {
            //arrange
            int num = 900;
            string actual, expected = "nine hundred ";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Tests For Thousands
        //nem tesztelem végig minden százasra, mert az elején leteszteltük, hogy 0-20 a számokat rendesen kiírja
        [TestMethod]
        public void ConvertNumbers_OneThousand()
        {
            //arrange
            int num = 1000;
            string actual, expected = "one thousand ";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_TwoThousand()
        {
            //arrange
            int num = 2000;
            string actual, expected = "two thousand ";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_SixThousand()
        {
            //arrange
            int num = 6000;
            string actual, expected = "six thousand ";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_NineThousand()
        {
            //arrange
            int num = 9000;
            string actual, expected = "nine thousand ";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Tests For Ten Thousands
        [TestMethod]
        public void ConvertNumbers_TenThousand()
        {
            //arrange
            int num = 10000;
            string actual, expected = "ten thousand ";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_FortyThousand()
        {
            //arrange
            int num = 40000;
            string actual, expected = "forty thousand ";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_NinetyThousand()
        {
            //arrange
            int num = 90000;
            string actual, expected = "ninety thousand ";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Tests For Hundred Thousands

        [TestMethod]
        public void ConvertNumbers_OneHundredThousand()
        {
            //arrange
            int num = 100000;
            string actual, expected = "one hundred thousand ";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_FiveHundredThousand()
        {
            //arrange
            int num = 500000;
            string actual, expected = "five hundred thousand ";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_NineHundredThousand()
        {
            //arrange
            int num = 900000;
            string actual, expected = "nine hundred thousand ";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Tests For Millions
        [TestMethod]
        public void ConvertNumbers_OneMIllion()
        {
            //arrange
            int num = 1000000;
            string actual, expected = "one million ";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_EightMIllion()
        {
            //arrange
            int num = 8000000;
            string actual, expected = "eight million ";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_NineMIllion()
        {
            //arrange
            int num = 9000000;
            string actual, expected = "nine million ";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Tests For Ten Millions

        [TestMethod]
        public void ConvertNumbers_NinetyMillion()
        {
            //arrange
            int num = 90000000;
            string actual, expected = "ninety million ";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_FiftyMillion()
        {
            //arrange
            int num = 50000000;
            string actual, expected = "fifty million ";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_TenMillion()
        {
            //arrange
            int num = 10000000;
            string actual, expected = "ten million ";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Tests For Hundred Millions

        [TestMethod]
        public void ConvertNumbers_NineHundredMillion()
        {
            //arrange
            int num = 900000000;
            string actual, expected = "nine hundred million ";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_FiveHundredMillion()
        {
            //arrange
            int num = 500000000;
            string actual, expected = "five hundred million ";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_OneHundredMillion()
        {
            //arrange
            int num = 100000000;
            string actual, expected = "one hundred million ";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Tests For Billion
        //2,147,483,647 felett túlcsordul az int,
        [TestMethod]
        public void ConvertNumbers_TwoBillion()
        {
            //arrange
            int num = 2000000000;
            string actual, expected = "two billion ";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_OneBillion()
        {
            //arrange
            int num = 1000000000;
            string actual, expected = "one billion ";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Tests For Negative Numbers

        [TestMethod]
        public void ConvertNumbers_NegativeLong()
        {
            //arrange
            int num = -7653;
            string actual, expected = "minus seven thousand six hundred and fifty-three";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_NegativeShort()
        {
            //arrange
            int num = -53;
            string actual, expected = "minus fify-three";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Tests For Complex Numbers

        [TestMethod]
        public void ConvertNumbers_ComplexInHundreds()
        {
            //arrange
            int num = 853;
            string actual, expected = "eight hundred and fifty-three";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_ComplexInThousands()
        {
            //arrange
            int num = 2765;
            string actual, expected = "two thousand seven hundred and sixty-five";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertNumbers_ComplexInMillions()
        {
            //arrange
            int num = 2754921;
            string actual, expected = "two million seven hundred and fifty-four thousand nine hundred and twenty-one";
            //act
            actual = NumberToWords.convertNumbers(num);
            //assert
            Assert.AreEqual(expected, actual);
        }

        #endregion
    }
}
