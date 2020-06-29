using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    public class SimpleCalculator
    {
        /// <summary>
        /// Method that calculates two numbers of type double, depending on what the operator is.
        /// </summary>
        /// <returns>result</returns>
        public static double CalculateTwoNumbers(double firstNum, string whichOperator, double secondNum)
        {
                //this function needs to include the user prompts and try-catch here,
                //instead of calling it from the Main
                if (whichOperator == "+")
                {
                    var result = (firstNum + secondNum);
                    return result;
                }
                else if (whichOperator == "-")
                {
                    var result = (firstNum - secondNum);
                    return result;
                }
                else if (whichOperator == "/")
                {
                    var result = (firstNum / secondNum);
                    return result;
                }
                else if (whichOperator == "*")
                {
                    var result = (firstNum * secondNum);
                    return result;
                }
                else
                {
                throw new ArgumentException("The operator is invalid. Please enter a valid operator(+ or - or / or *): ", whichOperator);
                }           
        }
    }
}
