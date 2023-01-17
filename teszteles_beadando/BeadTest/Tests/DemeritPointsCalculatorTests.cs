using BeadandoFeladat2021.MainPrograms;

namespace BeadTest.Tests
{
    [TestClass]
    public class DemeritPointsCalculatorTests
    {
        #region Tests For Exception

        [TestMethod]
        public void DemeritPointsCalculatorTest_0()
        {
            //Arrange
            DemeritPointsCalculator dpc = new DemeritPointsCalculator();
            //Act

            //Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => dpc.CalculateDemeritPoints(0));
        }

        [TestMethod]
        public void DemeritPointsCalculatorTest_181()
        {
            //Arrange
            DemeritPointsCalculator dpc = new DemeritPointsCalculator();
            //Act

            //Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => dpc.CalculateDemeritPoints(181));
        }

        #endregion

        #region Tests For Zero Point
        [TestMethod]
        public void DemeritPointsCalculatorTest_1()
        {
            //Arrange
            int speed1 = 1, expected1 = 0, actual1;
            DemeritPointsCalculator dpc = new();

            //Act
            actual1 = dpc.CalculateDemeritPoints(speed1);

            //Assert
            Assert.AreEqual(expected1, actual1);
        }

        [TestMethod]
        public void DemeritPointsCalculatorTest_40()
        {
            //Arrange
            int speed40 = 40, expected40 = 0, actual40;
            DemeritPointsCalculator dpc = new();

            //Act
            actual40 = dpc.CalculateDemeritPoints(speed40);

            //Assert
            Assert.AreEqual(expected40, actual40);
        }

        [TestMethod]
        public void DemeritPointsCalculatorTest_59()
        {
            //Arrange
            int speed59 = 59, expected59 = 0, actual59;
            DemeritPointsCalculator dpc = new();

            //Act
            actual59 = dpc.CalculateDemeritPoints(speed59);

            //Assert
            Assert.AreEqual(expected59, actual59);
        }
        #endregion

        #region Tests For One Point
        [TestMethod]
        public void DemeritPointsCalculatorTest_60()
        {
            //Arrange
            int speed60 = 60, expected60 = 1, actual60;
            DemeritPointsCalculator dpc = new();

            //Act
            actual60 = dpc.CalculateDemeritPoints(speed60);

            //Assert
            Assert.AreEqual(expected60, actual60);
        }

        [TestMethod]
        public void DemeritPointsCalculatorTest_67()
        {
            //Arrange
            int speed67 = 67, expected67 = 1, actual67;
            DemeritPointsCalculator dpc = new();

            //Act
            actual67 = dpc.CalculateDemeritPoints(speed67);

            //Assert
            Assert.AreEqual(expected67, actual67);
        }

        [TestMethod]
        public void DemeritPointsCalculatorTest_69()
        {
            //Arrange
            int speed69 = 69, expected69 = 1, actual69;
            DemeritPointsCalculator dpc = new();

            //Act
            actual69 = dpc.CalculateDemeritPoints(speed69);

            //Assert
            Assert.AreEqual(expected69, actual69);
        }
        #endregion

        #region Tests For Five Points
        [TestMethod]
        public void DemeritPointsCalculatorTest_100()
        {
            //Arrange
            int speed100 = 100, expected100 = 5, actual100;
            DemeritPointsCalculator dpc = new();

            //Act
            actual100 = dpc.CalculateDemeritPoints(speed100);

            //Assert
            Assert.AreEqual(actual100, expected100);
        }

        [TestMethod]
        public void DemeritPointsCalculatorTest_104()
        {
            //Arrange
            int speed104 = 104, expected104 = 5, actual104;
            DemeritPointsCalculator dpc = new();

            //Act
            actual104 = dpc.CalculateDemeritPoints(speed104);

            //Assert
            Assert.AreEqual(expected104, actual104);
        }

        [TestMethod]
        public void DemeritPointsCalculatorTest_109()
        {
            //Arrange
            int speed109 = 109, expected109 = 5, actual109;
            DemeritPointsCalculator dpc = new();

            //Act
            actual109 = dpc.CalculateDemeritPoints(speed109);

            //Assert
            Assert.AreEqual(expected109, actual109);
        }
        #endregion

        #region Tests For Max Points
        [TestMethod]
        public void DemeritPointsCalculatorTest_170()
        {
            //Arrange
            int speed170 = 170, expected170 = 12, actual170;
            DemeritPointsCalculator dpc = new();

            //Act
            actual170 = dpc.CalculateDemeritPoints(speed170);

            //Assert
            Assert.AreEqual(expected170, actual170);
        }

        [TestMethod]
        public void DemeritPointsCalculatorTest_174()
        {
            //Arrange
            int speed174 = 174, expected174 = 12, actual174;
            DemeritPointsCalculator dpc = new();

            //Act
            actual174 = dpc.CalculateDemeritPoints(speed174);

            //Assert
            Assert.AreEqual(expected174, actual174);
        }

        [TestMethod]
        public void DemeritPointsCalculatorTest_179()
        {
            //Arrange
            int speed179 = 179, expected179 = 12, actual179;
            DemeritPointsCalculator dpc = new();

            //Act
            actual179 = dpc.CalculateDemeritPoints(speed179);

            //Assert
            Assert.AreEqual(expected179, actual179);
        }
        #endregion
    }
}