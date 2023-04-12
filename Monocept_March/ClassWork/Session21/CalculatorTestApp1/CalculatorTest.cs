using CalculatorTestApp1.Model;
using System;

namespace CalculatorTestApp1
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void ShouldCubeAnEvenNumber_2_AndProduceResult()
        {
            int expectedResult = 8;
            Calculator calculator = new Calculator();
            int actualResult = calculator.CubeEvenNo(2);
            Assert.IsTrue(expectedResult==actualResult);
        }
        [TestMethod]
        public void CubingOddNumberShouldResultIntegerNegativeValue()
        {
            int expectedResult = -1;
            Calculator calculator = new Calculator();
            int actualResult = calculator.CubeEvenNo(3);
            Assert.IsTrue(expectedResult == actualResult);
        }
        [TestMethod]
        public void Add_ShouldTakeInfiniteParameterAndProduceResult()
        {
            int expectedResult = 200;
            Calculator calculator = new Calculator();
            int actualResult = calculator.Add(10, 20, 30, 40,50, 50);
            Assert.IsTrue(actualResult == expectedResult);
        }
        [TestMethod]
        public void Add_ShouldTakeSingleParameterAndProduceResult()
        {
            int expectedResult = 10;
            Calculator calculator = new Calculator();
            int actualResult = calculator.Add(10);
            Assert.IsTrue(actualResult == expectedResult);
        }
        [TestMethod]
        public void Add_ShouldTakeTwoNegativeParameterAndProduceResult()
        {
            int expectedResult =-20;
            Calculator calculator = new Calculator();
            int actualResult = calculator.Add(-10,-10);
            Assert.IsTrue(actualResult == expectedResult);
        }
    }
}
