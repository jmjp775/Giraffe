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
        public double CalculateTwoNumbers(string op)
        {
                Console.Write("Enter a number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter an operator: ");
                string op = Console.ReadLine();

                Console.Write("Enter another number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                if (op == "+")
                {
                    var result = (num1 + num2);
                    return result;
                }
                else if (op == "-")
                {
                    var result = (num1 - num2);
                    return result;
                }
                else if (op == "/")
                {
                    var result = (num1 / num2);
                    return result;
                }
                else 
                {
                    var result = (num1 * num2);
                    return result;
                }
        }
    }
}
