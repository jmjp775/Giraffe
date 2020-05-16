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
            //Console.Write("Enter a number: ");
            //double firstNum = Convert.ToDouble(Console.ReadLine());



            //check that user entered a valid operator. If not, they need to re-enter until they enter a valid operator.
            //while (whichOperator != "+" || whichOperator != "-" || whichOperator != "/" || whichOperator != "*")
            //{
                //Console.WriteLine("You entered an invalid operator. Please try again: ");
                //whichOperator = Console.ReadLine();

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
            //}


            
            
            

            // catch (System.ArgumentException e)
            //{
            //    System.Console.WriteLine(e.Message);
            //    throw new System.ArgumentException("Invalid operator. ", e);
            //}
        }
    }
}
