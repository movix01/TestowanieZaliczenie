using NUnit.Framework;
using System;
using Zaliczenie;

namespace Zaliczenie.UnitTests
{
    [TestFixture]
    class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_AddTwoNumbers_CorrectResult()
        {
            // Assign
            var num1 = 3;
            var num2 = 5;

            // Act
            var result = _calculator.Add(num1, num2);

            // Assert
            Assert.AreEqual(8, result);
        }

        [Test]
        public void Subtract_SubtractTwoNumbers_CorrectResult()
        {
            // Assign
            var num1 = 5;
            var num2 = 3;

            // Act
            var result = _calculator.Subtract(num1, num2);

            // Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Multiyply_MultiplyTwoNumbers_CorrectResult()
        {
            // Assign
            var num1 = 3;
            var num2 = 5;

            // Act
            var result = _calculator.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(15, result);
        }

        [Test]
        public void Divide_DivideTwoNumbers_CorrectResult()
        {
            // Assign
            var num1 = 6;
            var num2 = 3;

            // Act
            var result = _calculator.Divide(num1, num2);

            // Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Divide_DivideByZero_Error()
        {
            // Assign
            var num1 = 6;
            var num2 = 0;

            // Act
            var result = _calculator.Divide(num1, num2);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Power_PowerTwoNumbers_CorrectResult()
        {
            // Assign
            var num1 = 10;
            var num2 = 3;

            // Act
            var result = _calculator.Power(num1, num2);

            // Assert
            Assert.AreEqual(1000, result);
        }

        [Test]
        public void SquareRoot_SquareRootANumber_CorrectResult()
        {
            // Assign
            var num = 9;

            // Act
            var result = _calculator.SquareRoot(num);

            // Assert
            Assert.AreEqual(3, result);
        }

        [Test]
        public void SquareRoot_SquareRootANegativeNumber_Error()
        {
            // Assign
            var num = -9;

            // Act
            var result = _calculator.SquareRoot(num);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Modulo_ModuloOfTwoNumbers_CorrectResult()
        {
            // Assign
            var num1 = 5;
            var num2 = 3;

            // Act
            var result = _calculator.Modulo(num1, num2);

            // Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Modulo_ModuloOfDividingByZero_Error()
        {
            // Assign
            var num1 = 5;
            var num2 = 0;

            // Act
            var result = _calculator.Modulo(num1, num2);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void NaturalLogarithm_NegativNumber_Error()
        {
            // Assign
            var num = -3;

            // Act
            var result = _calculator.NaturalLogarithm(num);

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}
