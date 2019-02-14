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

            Equation Addition = new Equation();
            Addition.UserNum = userNum;
            Equation Divide = new Equation();
            Divide.UserNum = userNum;
            Equation Multiply = new Equation();
            Multiply.UserNum = userNum;

            Equation Run = new Equation();
            Run.Addition();
            Run.Divide();
            Run.Multiply();
            

            Console.WriteLine();
            Console.ReadLine();
            


        }
    }
}
