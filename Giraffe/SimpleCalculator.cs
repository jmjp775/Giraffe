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
                    throw new ArgumentException();
                }           
        }
    }
}
