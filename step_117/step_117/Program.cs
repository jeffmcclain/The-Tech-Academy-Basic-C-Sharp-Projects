using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_117
{
    static class Program
    {
        static void Main(string[] args)
        {
            // instantiate object from class 'Equation'
            Equation answer = new Equation();

            // declare integer input variables 
            int userNumOne = 0;
            int userNumTwo = 0;

            // declare boolean to manage format exception loop
            bool tryAgain = true;

            // loop will iterate until input requirements met
            while (tryAgain)
            {
                try
                {
                    // prompt user to select a number
                    Console.WriteLine("Enter a number:");
                    userNumOne = Convert.ToInt32(Console.ReadLine());
                    // change boolean value if input requirements satisfied
                    tryAgain = false;
                }
                catch (FormatException) // catch any incompatable input values and print error message to console
                {
                    Console.WriteLine("Please enter a whole number...");
                    Console.ReadLine();
                }
                catch (DivideByZeroException) // catch if user selects 0 and print error message to console
                {
                    Console.WriteLine("Select a whole number greater than zero...");
                    Console.ReadLine();
                }
            }

            // prompt user for a second OPTIONAL number
            Console.WriteLine("Enter a second (OPTIONAL) number:");
            string userInputTwo = Console.ReadLine();

            // check string variable 'userInputTwo' for user input, convert value to an int and assign to 'userNumTwo'
            if (userInputTwo is "")
            {
                userInputTwo = "0";
                userNumTwo = Convert.ToInt32(userInputTwo);
            }
            else
            {
                userNumTwo = Convert.ToInt32(userInputTwo);
            }

            // call 'Divide' method from 'Equation' and print results to console
            answer.Divide(userNumOne);
            answer.Multiply(userNumOne, out int answerOut ,userNumTwo);
            answer.Multiply(userNumOne);

            // print to console stored input variables and values passed out of, or returned from, methods
            Console.WriteLine(userNumOne + " multiplied by " + userNumTwo + " equals " + answerOut +
                "\n" + userNumOne + " multiplied by 5 equals " + answer.Multiply(userNumOne));
            Console.ReadLine();
        }
    }
}
