using AccountUnitTestApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountUnitTestApp
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void ShouldCubeAnEvenNumber_2_AndProduceResultOf_8()
        {
            int expectedResult = 8;
            Calculator calculator = new Calculator();
            int actualResult = calculator.CubeOnlyEvenNumbers(2);
            Assert.IsTrue(expectedResult== actualResult);
        }
        [TestMethod]
        public void CubeOfOddNumberShouldResultInNegativeValue()
        {
            int expectedResult = -1;
            Calculator calculator = new Calculator();
            int actualResult = calculator.CubeOnlyEvenNumbers(3);
            Assert.IsTrue(expectedResult == actualResult);
        }
        [TestMethod]
        public void AddFunction_ShouldTakeInfiniteParameters_AndProduceResult()
        {
            int expectedResult = 150;
            Calculator calculator = new Calculator();
            int actualResult = calculator.Add(10, 20, 30, 40, 50);
            Assert.IsTrue(expectedResult == actualResult);
        }
        [TestMethod]
        public void AddFunction_ShouldTakeSingleParameter_AndReturnSameValueBack()
        {
            int expectedResult = 10;
            Calculator calculator = new Calculator();
            int actualResult = calculator.Add(10);
            Assert.IsTrue(expectedResult == actualResult);
        }
        [TestMethod]
        public void AddFunction_ShouldTakeNegativeValues_AndProduceResult()
        {
            int expectedResult = 0;
            Calculator calculator = new Calculator();
            int actualResult = calculator.Add(10,-10);
            Assert.IsTrue(expectedResult == actualResult);
        }
    }
}
