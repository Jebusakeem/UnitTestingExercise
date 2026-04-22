using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(2, 13, 5, 20)]
        [InlineData(20, 3, 7, 30)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calculator = new Calculator();
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
                var actual = calculator.Add(num1, num2, num3);
            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 3, 1)]//Add test data <-------
        [InlineData(5, 3, 2)]
        [InlineData(6, 3, 3)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,6, 30)]//Add test data <-------
        [InlineData(6, 3, 18)]
        [InlineData(9, 3, 27)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 2, 4)]//Add test data <-------
        [InlineData(6, 3, 2)]
        [InlineData(18, 3, 6)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calculator = new Calculator();
            //Act
            var actual = calculator.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
