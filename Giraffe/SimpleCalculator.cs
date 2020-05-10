using System;
using System.Collections.Generic;
using System.IO;
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
        public double CalculateTwoNumbers()
        {
            //string operator;
            string[] operatorArray = {"+", "-", "*", "/" };

            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator: ");
            string operatorAsString = Console.ReadLine();

            if (operatorArray.Any(operatorAsString.Contains))
            {
                if (operatorAsString == "+")
                {
                    var result = (num1 + num2);
                    return result;
                }
                else if (operatorAsString == "-")
                {
                    var result = (num1 - num2);
                    return result;
                }
                else if (operatorAsString == "/")
                {
                    var result = (num1 / num2);
                    return result;
                }
                else if (operatorAsString == "*")
                {
                    var result = (num1 * num2);
                    return result;
                }
            }
            else
            {
                Console.WriteLine("This is an invalid operator. Please enter a valid operator: ");
                operatorAsString = Console.ReadLine();
            }






        }

        private bool IsOperatorValid(string operator)
        {
            string[] operatorArray = { "+", "-", "*", "/" };
            
        }

    }
}