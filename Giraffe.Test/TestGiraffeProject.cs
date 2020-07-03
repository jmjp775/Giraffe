using System;
using Xunit;
using Giraffe;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;

namespace Giraffe.Test
{
    public class TestGiraffeProject
    {
        [Fact]
        public void SimpleCalculatorPassWithDoubleValues()
        {
            //Arrange
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

        //[Fact]
        //public void SimpleCalculatorFailWithInvalidOperator()
        //{
        //    //Arrange
        //    double doubleNum1 = 3.5;
        //    double doubleNum2 = 50.5;
        //    string invalidOperator = "plus";
        //    //Act
        //    double actualResult = SimpleCalculator.CalculateTwoNumbers(doubleNum1, invalidOperator, doubleNum2);
        //    //var exceptionMessage = new SimpleCalculator();

        //    //Assert
        //    //Assert.Throws<ArgumentException>(() => exceptionMessage.ToString(doubleNum1, invalidOperator, doubleNum2);
        //    Assert.Throws<ArgumentException>(() => { throw new ArgumentException(); });


        //}

        //[Fact]
        //public void FailWithInvalidOperatorSimpleCalculator()
        //{
        //    //Arrange
        //    double doubleNum1 = 3.5;
        //    double doubleNum2 = 50.5;
        //    string invalidOperator = "plus";

        //    var sut = new SimpleCalculator();

        //    //Arrange
        //    //Action act = () => sut.CalculateTwoNumbers("");

        //    //Act
        //    double actualResult = SimpleCalculator.CalculateTwoNumbers(doubleNum1, invalidOperator, doubleNum2);

        //    ArgumentException ex = Assert.Throws<ArgumentException>(() => actualResult);

        //    Assert.Equal("First exception was caught The operator is invalid (+ or - or / or *): ", ex.Message);
        //}

        //public void FailWithInvalidOperatorSimpleCalculator_Two()
        //{
        //    //Act
        //    static void act() => SimpleCalculator.CalculateTwoNumbers(3.5, "plus", 50.5);

        //    Assert.ThrowsAsync<ArgumentException>(() => { throw new ArgumentException(); });

        //}
    }
}
