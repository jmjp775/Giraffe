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
        /// Method that adds to numbers of type double.
        /// </summary>
        /// <returns>SumOfTwoNumbers</returns>
        public double AddTwoDoubles()
        {
            Console.Write("Enter a number: ");
             double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number: ");
             double num2 = Convert.ToDouble(Console.ReadLine());

            var SumOfTwoNumbers = (num1 + num2);
            return SumOfTwoNumbers;

            //Console.ReadLine();
        }
        
    }
}
