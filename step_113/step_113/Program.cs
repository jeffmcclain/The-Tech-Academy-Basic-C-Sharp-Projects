using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_113
{
    class Program
    {
        static void Main(string[] args)
        {
           

            // declare bool and assign true so that the loop continues until input requirements are met
            bool tryAgain = true;

            // declare int variables in which user input will be assigned
            int numOne = 0;
            int numTwo = 0;

            while (tryAgain)
            {
                try
                {
                    // prompt user to select the first number
                    Console.WriteLine("\nEnter a number: ");
                    int inputOne = Convert.ToInt32(Console.ReadLine());
                    numOne = inputOne;

                    // prompt user to select another number
                    Console.WriteLine("\nEnter another number: ");
                    int inputTwo = Convert.ToInt32(Console.ReadLine());
                    numTwo = inputTwo;

                    // change value of bool to false, once input requirements met
                    tryAgain = false;
                }
                catch (FormatException) // setup catch to check for format errors and print message to console
                {
                    Console.WriteLine("\nPlease enter a whole number...");
                    Console.ReadLine();
                }
            }

            // instantiate the class 'Equation'
            Equation method = new Equation();
            method.Math(numOne, numTwo);

            Console.ReadLine();
        }
    }
}
