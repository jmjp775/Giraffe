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
            string checkOperator = whichOperator;
            string[] operatorArray = { "+", "-", "*", "/" };
            foreach (string x in operatorArray)
            {
                while (!checkOperator.Contains(x))
                {
                    Console.WriteLine("{0} is an invalid operator.", checkOperator);
                    Console.Write("Re-enter a valid operator: ");
                    string checkNewOperator = Console.ReadLine();
                    checkOperator = checkNewOperator;
                }
            }


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
            else
            {
                var result = (firstNum * secondNum);
                return result;
            }
        }
    }
}
