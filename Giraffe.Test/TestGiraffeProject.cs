using System;
using Xunit;
using Giraffe;

namespace Giraffe.Test
{
    public class TestGiraffeProject
    {
        [Fact]
        public void SimpleCalculatorPassWithDoubleValues()
        {
            //Arrange
            //var multiplyDoubleValues = SimpleCalculator();
            double doubleNum1 = 3.5;
            double doubleNum2 = 50.5;
            double expectedResult = 176.75;
            //const string operator = "*";

            //Act
            double actualResult = SimpleCalculator.CalculateTwoNumbers(doubleNum1,"*", doubleNum2);

            //Assert
            //double actualResult = SimpleCalculator.CalculateTwoNumbers
            Assert.Equal(expectedResult, actualResult);

        }
    }
}
