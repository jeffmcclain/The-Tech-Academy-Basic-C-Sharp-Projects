using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_115
{
    class Program
    {
        static void Main(string[] args)
        {
            Equation answer = new Equation();
            int inputOne = 0;
            int inputTwo = 0;

            // prompt user to select a number to input
            Console.WriteLine("Enter a number:");
            inputOne = Convert.ToInt32(Console.ReadLine());
            

            // prompt user to select and optional second number
            Console.WriteLine("Enter a second number (OPTIONAL): ");
            string inputString = Console.ReadLine();

            // check for a value of the second user input and execute the qualifying statement 
            if (inputString is "")
            {
                answer.Addition(inputOne); // pass one parameter
            }
            else // if user selects a second input, pass both values to method
            {
                inputTwo = Convert.ToInt32(inputString);
                answer.Addition(inputOne, inputTwo); 
            }
            

            // print the value returned from the method 'Addition' in class 'Equation'
            Console.WriteLine("\n" + inputOne + " plus " + inputTwo + " equals " + answer.Addition(inputOne, inputTwo));
            Console.ReadLine();
        }
    }
}
