﻿using System;
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
            SimpleCalculator calculator = new SimpleCalculator();
            double sumOfTwoDoubles = calculator.AddTwoDoubles();
            Console.WriteLine($"The sum of these 2 values is: {sumOfTwoDoubles}\n");

            //Calls MadLibs method to console
            MadLibs madLibsPhrase = new MadLibs();
            string showMadLibs = madLibsPhrase.PlayMadLibs();
            Console.WriteLine($"{showMadLibs}\n");

            //Calls GetIndexOfArray to console
            int[] array = { 3, 15, 7, 10, 18, 6 };
            int item = 7;

            int index = array.GetIndexOfArray(item);
            if (index != -1)
            {
                Console.WriteLine(string.Format("Element {0} found at index {1} \n", item, index));
            }
            else
            {
                Console.WriteLine("Element not found in array.\n");
            }

            //Create a method to say Hi to user
            static void SayHi(string name)
            {
                Console.WriteLine("Hello " + name);
            }

        }
    }
}
