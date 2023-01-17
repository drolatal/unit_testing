using BeadandoFeladat2021.MainPrograms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeadTest.Tests
{
    [TestClass]
    public class MathemathicsTests
    {
        #region Tests For Add
        [TestMethod]
        public void Add_BothNegative() {
            //Arrange
            int a = -1, b = -2;
            int actual, expected = -3;
            Mathemathics mathemathics= new Mathemathics();
            //Act
            actual = mathemathics.Add(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Add_GreaterNegative()//értsd: abszolút értékben nagyobb
        {
            //Arrange
            int a = -3, b = 2;
            int actual, expected = -1;
            Mathemathics mathemathics = new Mathemathics();
            //Act
            actual = mathemathics.Add(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_GreaterPozitive()//értsd: abszolút értékben nagyobb
        {
            //Arrange
            int a = 6, b = -2;
            int actual, expected = 4;
            Mathemathics mathemathics = new Mathemathics();
            //Act
            actual = mathemathics.Add(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_BothPozitive()
        {
            //Arrange
            int a = 6, b = 2;
            int actual, expected = 8;
            Mathemathics mathemathics = new Mathemathics();
            //Act
            actual = mathemathics.Add(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Kommutativity()
        {
            //Arrange
            int a = 6, b = -2;
            int secondSide,firstSide;
            Mathemathics mathemathics = new Mathemathics();
            //Act
            firstSide = mathemathics.Add(a, b);
            secondSide = mathemathics.Add(b, a);
            //Assert
            Assert.AreEqual(firstSide,secondSide);
        }

        [TestMethod]
        public void Add_NeutralElement()
        {
            //Arrange
            int a = 6, b = 0;
            int actual, expected = 6;
            Mathemathics mathemathics = new Mathemathics();
            //Act
            actual = mathemathics.Add(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_ThrowsOverflowExceptionOnTop()
        {
            //Arrange
            int a = 1998, b = int.MaxValue;
            Mathemathics mathemathics = new Mathemathics();
            //Act
            //Assert
            Assert.ThrowsException<OverflowException>(()=>mathemathics.Add(a, b));
        }

        [TestMethod]
        public void Add_ThrowsOverflowExceptionOnBottom()
        {
            //Arrange
            int a = -1, b = int.MinValue;
            Mathemathics mathemathics = new Mathemathics();
            //Act
            //Assert
            Assert.ThrowsException<OverflowException>(() => mathemathics.Add(a, b));
        }

        #endregion

        #region Tests For Max
        [TestMethod]
        public void Max_BothPositive() {
            //Arrange
            int a = 5, b = 9;
            int actual, expected = 9;
            Mathemathics m = new Mathemathics();
            //Act
            actual = m.Max(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Max_BothPositiveSwitched()
        {
            //Arrange
            int a = 9, b = 5;
            int actual, expected = 9;
            Mathemathics m = new Mathemathics();
            //Act
            actual = m.Max(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Max_BothNegativeS()
        {
            //Arrange
            int a = -9, b = -5;
            int actual, expected = -5;
            Mathemathics m = new Mathemathics();
            //Act
            actual = m.Max(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Max_BothNegativeSwitched()
        {
            //Arrange
            int a = -5, b = -9;
            int actual, expected = -5;
            Mathemathics m = new Mathemathics();
            //Act
            actual = m.Max(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Max_SameNumber()
        {
            //Arrange
            int a = 9, b = 9;
            int actual, expected = 9;
            Mathemathics m = new Mathemathics();
            //Act
            actual = m.Max(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Max_ZeroPozitive()
        {
            //Arrange
            int a = 0, b = 9;
            int actual, expected = 9;
            Mathemathics m = new Mathemathics();
            //Act
            actual = m.Max(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Max_ZeroNegative()
        {
            //Arrange
            int a = 0, b = -9;
            int actual, expected = 0;
            Mathemathics m = new Mathemathics();
            //Act
            actual = m.Max(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region Tests For GetOddNumbers Testing Averagely
        
        [TestMethod]
        public void Odd_EvenLimit()
        {
            //arrange
            int limit = 8;
            IEnumerable<int> actual;
            List<int> expected = new List<int>() {1, 3, 5, 7 };
            Mathemathics m = new Mathemathics();
            //act
            actual = m.GetOddNumbers(limit);
            //assert
            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod]
        public void Odd_OddLimit()
        {
            //arrange
            int limit = 7;
            List<int> expected = new List<int>() {1, 3, 5, 7 };
            IEnumerable<int> actual;
            Mathemathics m = new Mathemathics();
            //act
            actual = m.GetOddNumbers(limit);
            //assert
            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod]
        public void Odd_LimitIsNegative()
        {
            //arrange
            int limit = -7;
            List<int> expected = new List<int>() {-17,-15,-13, -11,-9,-7 };
            IEnumerable<int> actual;
            Mathemathics m = new Mathemathics();
            //act
            actual = m.GetOddNumbers(limit);
            //assert
            Assert.IsTrue(actual.SequenceEqual(expected));
        }
        
        // vagy ha már nem minden páratlan számot adunk meg:

        [TestMethod]
        public void Odd_LimitIsLessThanTwo()
        {
            //arrange
            int limit = 1;
            Mathemathics m = new Mathemathics();
            //act
            //assert
            Assert.ThrowsException<ArgumentException>(()=> m.GetOddNumbers(limit));
        }

        #endregion


        /*#region Tests For GetOddNumbers Testing Mathemathically
        //Ugye a feladat azt mondta, hogy melyek azok a páratlan számok,
        //amik kisebbek az adott limitnél...
        //Szerintem ennél a feladatnál jobb lett volna "egy adott intervallumban"-ként megfogalmazni,
        //vagy pontosabban pl: melyek azok a pozitív páratlan számok,
        //de most ugye így is csak az integer korlátaiban van tesztelve.
        
        
        [TestMethod]
        public void Odd_EvenLimitMathemathicalTest()
        {
            //arrange
            int limit = 8;
            IEnumerable<int> actual;
            Mathemathics m = new Mathemathics();
            List<int> expected = new List<int>();
            for (int i = int.MinValue; i <= limit; i++)
            {
                if (i % 2 != 0) {
                    expected.Add(i);
                }
            }
            //act
            actual = m.GetOddNumbers(limit);
            //assert
            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod]
        public void Odd_OddLimitMathemathicalTest()
        {
            //arrange
            int limit = 7;
            IEnumerable<int> actual;
            Mathemathics m = new Mathemathics();
            List<int> expected = new List<int>();
            for (int i = int.MinValue; i <= limit; i++)
            {
                if (i % 2 != 0)
                {
                    expected.Add(i);
                }
            }
            //act
            actual = m.GetOddNumbers(limit);
            //assert
            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [TestMethod]
        public void Odd_LimitIsNegativeMathemathicalTest()
        {
            //arrange
            int limit = -7;
            IEnumerable<int> actual;
            Mathemathics m = new Mathemathics();
            List<int> expected = new List<int>();
            for (int i = int.MinValue; i <= limit; i++)
            {
                if (i % 2 != 0)
                {
                    expected.Add(i);
                }
            }
            //act
            actual = m.GetOddNumbers(limit);
            //assert
            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        #endregion*/

    }
}
