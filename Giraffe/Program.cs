using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    public class Program
    {
        public int[] array;

        static void Main(string[] args)
        {
            //example of how to call a static method here: https://www.c-sharpcorner.com/UploadFile/abhikumarvatsa/static-methods-in-C-Sharp/

            //Calls SimpleCalculator method to console
            //try
            //{
            //    Console.Write("Enter a number: ");
            //    double num1 = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Enter an operator: ");
            //    //passing op as a value-type parameter by value
            //    string op = Console.ReadLine();

            //    Console.Write("Enter another number: ");
            //    double num2 = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine(SimpleCalculator.CalculateTwoNumbers(num1, op, num2));
            //}
            ////Most specific 
            //catch (ArgumentException e)
            //{
            //    Console.WriteLine("{0} first exception was caught " + e.Message);
            //}
            ////Least specific
            //catch (FormatException e)
            //{
            //    Console.WriteLine("{0} Second exception was caught " + e.Message);
            //}


            //Calls MadLibs method to console
            //MadLibs madLibsPhrase = new MadLibs();
            //string showMadLibs = madLibsPhrase.PlayMadLibs();
            //Console.WriteLine($"{showMadLibs}\n");

            //Calls GetIndexOfArray to console
            //int[] array = { 3, 15, 7, 10, 18, 6 };
            //int item = 7;

            //int index = array.GetIndexOfArray(item);
            //if (index != -1)
            //{
            //    Console.WriteLine(string.Format("Element {0} found at index {1} \n", item, index));
            //}
            //else
            //{
            //    Console.WriteLine("Element not found in array.\n");
            //}

            //Calls SayHiMethod
            //SayHiMethod.GetUserGreeting("Mike");

            //Use CubeANumber method to cube a number
            //Console.WriteLine(CubeANumber.ReturnCube(5));

            //Calls IfStatementPractice.IfNotSundayThenWhat to display what exercises I should do
            //DayOfWeek day = DateTime.Now.DayOfWeek;

            //IfStatementPractice adviceForToday = new IfStatementPractice();

            //string displayTodaysAdvice = adviceForToday.IfNotSundayThenWhat();
            //Console.WriteLine($"{displayTodaysAdvice}\n");

            //Calls FindMaxValue.GetMaxValue(int, int) to display which number is bigger: num1 or num2
            //FindMaxValue whichNumIsGreater = new FindMaxValue();

            //int displayMaxValue = whichNumIsGreater.GetMaxValue(10, 21, 56);
            //Console.WriteLine($"{displayMaxValue} is the greater number \n");

            //Calls SwitchStatementWhichDayIsIt.GetDay(int dayNum) to display which day of the week it is
            // SwitchStatementWhichDayIsIt whatDayIsIt = new SwitchStatementWhichDayIsIt();

            // Console.Write("Enter a number from 0 to 7 : ");
            // int numberFromZeroToSeven = Convert.ToInt32(Console.ReadLine());

            // string displayWhichDayIsAssociatedWithNumber = whatDayIsIt.GetDay(numberFromZeroToSeven);

            // Console.WriteLine($"{numberFromZeroToSeven} equals {displayWhichDayIsAssociatedWithNumber}");

            //Calls IncrementWhileLoop.IncrementInt(int numVal) to display how it increments the value 
            //from 1 to 5 and exits the loop when it reaches 5
            int numVal = 1;
            IncrementWhileLoop incrementValue = new IncrementWhileLoop();

            int displayEachValue = incrementValue.IncrementInt(numVal);
        }
    }
}