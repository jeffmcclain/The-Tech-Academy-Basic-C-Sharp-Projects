using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_111
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // boolean will iterate thru try/catch until user input meets parameters
            bool tryAgain = true;

            // instantiate int variable that will store user input
            int userNum = 0;
            
            // loops until user selects an integer
            while (tryAgain)
            {
                try
                {
                    // prompt user to select a number
                    Console.WriteLine("Enter a number: ");
                    int inputNum = Convert.ToInt32(Console.ReadLine()); // convert the input string to an integer and store in variable
                    userNum = inputNum;
                    tryAgain = false;
                }
                catch (FormatException)
                {
                    // print to screen this error when user selects an invalid input value
                    Console.WriteLine("Please enter a whole number...");
                    Console.ReadLine();
                }
            }
            
            // create new object with the datatype 'Equation' and variable 'answer'
            Equation answer = new Equation();
            // use the object assigned to 'answer' to call methods within the class 'Equation' and pass in the variable 'userNum' 
            answer.Addition(userNum);
            answer.Divide(userNum);
            answer.Multiply(userNum);

            // print to console the stored values from the outside methods
            Console.WriteLine("\n 55 plus " + userNum + " equals " + answer.Addition(userNum) + 
                "\n\n 100,000 divided by " + userNum + " equals " + answer.Divide(userNum) + 
                "\n\n 5 multiplied by " + userNum + " equals " + answer.Multiply(userNum));
            Console.ReadLine();
            


        }
    }
}
