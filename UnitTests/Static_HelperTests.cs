using ClassLibrary1;
using NUnit.Framework;
using System;

namespace UnitTests
{
    public class Static_HelperTests
    {
        [TestCase(5, 10, 15)]
        [TestCase(0, 9, 9)]
        [TestCase(-10, 10, 0)]
        [TestCase(-5, -5, -10)]
        [TestCase(14, -14, 0)]
        public void Sum_WhenFirstNumAndSecondNumInitialized_ShouldFindSumOfTwoNumbers(
            double firstNum, double secondNum, double expectedResult)
        {
            double actualResult = Static_Helper.Sum(firstNum,secondNum);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(15, 10, 5)]
        [TestCase(-10, -10, 0)]
        [TestCase(-10, 10, -20)]
        [TestCase(0, 5, -5)]
        [TestCase(20, 20, 0)]
        public void Sub_WhenFirstNumAndSecondNumInitialized_ShouldFindSubstractionOfTwoNumbers(
            double firstNum, double secondNum, double expectedResult)
        {
            double actualResult = Static_Helper.Sub(firstNum, secondNum);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(3, 2, 6)]
        [TestCase(10, 0, 0)]
        [TestCase(-2, -4, 8)]
        [TestCase(-5, 2, -10)]
        [TestCase(0, 20, 0)]
        public void Mult_WhenFirstNumAndSecondNumInitialized_ShouldFindMultiplicationOfTwoNumbers(
            double firstNum, double secondNum, double expectedResult)
        {
            double actualResult = Static_Helper.Mult(firstNum, secondNum);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(10, 2, 5)]
        [TestCase(10, -2, -5)]
        [TestCase(-20, -5, 4)]
        [TestCase(5, 4, 1.25)]
        [TestCase(-10, 8, -1.25)]
        public void Div_WhenFirstNumAndSecondNumInitializedAndSecondNumIsNotZero_ShouldFindDivisionOfTwoNumbers(
            double firstNum, double secondNum, double expectedResult)
        {
            double actualResult = Static_Helper.Div(firstNum, secondNum);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Div_WhenFirstNumAndSecondNumInitializedAndSecondNumIsZero_ShouldThrowDivideByZeroException()
        {
            try
            {
                Static_Helper.Div(10, 0);
            }
            catch (DivideByZeroException ex)
            {
                Assert.AreEqual("Second argument was zero!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(0, 32)]
        [TestCase(-8, 17.6)]
        [TestCase(7, 44.6)]
        [TestCase(-25, -13)]
        [TestCase(23, 73.4)]
        public void CelsiusToFahrenheit_WhenTemperatureCelsiusPassed_ShouldReturnTemperatureInFahrenheit(
            double tempInCelsius, double expectedResult)
        {
            double actualResult = Static_Helper.CelsiusToFahrenheit(tempInCelsius);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(0, -17.78)]
        [TestCase(5, -15)]
        [TestCase(7, -13.89)]
        [TestCase(50, 10)]
        [TestCase(59, 15)]
        public void FahrenheitToCelsius_WhenTemperatureFahrenheitPassed_ShouldReturnTemperatureInCelsius(
            double tempInFahrenheit, double expectedResult)
        {
            double actualResult = Static_Helper.FahrenheitToCelsius(tempInFahrenheit);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("Hello", 1, 5)]
        [TestCase("World", 1, 5)]
        [TestCase("SomeWord", 4, 5)]
        [TestCase("Hello", 4, 2)]
        [TestCase("SomeVeryLongWordForThisTest", 7, 21)]
        public void StrCount_WhenStringIsNotNullAndPositionIsNotEqualToZeroAndNotLessThanZeroPassed_ShouldCalculateCharsFromPosition(
            string str, int position, int expectedResult)
        {
            int actualResult = Static_Helper.StrCount(str, position);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void StrCount_WhenStringIsNullPassed_ShouldThrowArgumentException()
        {
            try
            {
                Static_Helper.StrCount(null, 2);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("String was null!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void StrCount_WhenStringIsPassedAndPositionIsEqualToZeroOrLess_ShouldThrowArgumentException()
        {
            try
            {
                Static_Helper.StrCount("Hello", 0);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Position was less than zero or equal to zero!", ex.Message);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(new[] { 5, 3, 7, 2, 1 }, new[] {1, 2, 3, 5, 7 })]
        [TestCase(new[] { 3, 2, 1, 0, 10 }, new[] {0, 1, 2, 3, 10 })]
        [TestCase(new[] { 17, 23, 0, 2, 1 }, new[] { 0, 1, 2, 17, 23 })]
        [TestCase(new[] { 5, 5, 1, 2, 1 }, new[] { 1, 1, 2, 5, 5 })]
        [TestCase(new[] { -7, -1, -10, 1, 0 }, new[] { -10, -7, -1, 0, 1 })]
        public void OurSort_WhenArrayPassed_ShouldReturnSortedArrayAscending(
            int[] array, int[] expectedResult)
        {
            int [] actualResult = Static_Helper.OurSort(array);
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestCaseSource("MaxOfDiagonalCases")]
        public void GetMaxElementOfDiagonal_WhenArrayPassed_ShouldReturnMaxElentOfDiagonal(
            int[,]array, int expectedResult) 
        {
            int actualResult = Static_Helper.GetMaxElementOfDiagonal(array);
            Assert.AreEqual(expectedResult, actualResult);
        }

        static object[] MaxOfDiagonalCases =
        {
            new object[] { new[,] { {1, 2, 3 },
                                    {4, 5, 6 },
                                    {7, 8, 9 } }, 9},

            new object[] { new[,] { {10, 1, 4 },
                                    {6, 5, 8 },
                                    {0, 0, 9 } }, 10},

            new object[] { new[,] { {1, 2, 3 },
                                    {4, 25, 6 },
                                    {7, 8, 0 } }, 25},

            new object[] { new[,] { {99, 5, 88 },
                                    {104, 55, 68 },
                                    {79, 105, 100 } }, 100},

            new object[] { new[,] { {0, 2, 3 },
                                    {4, 0, 6 },
                                    {7, 8, 0 } }, 0},
        };
    }
}