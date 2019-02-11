using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_106
{
    class Program
    {
        static void Main(string[] args)
        {

            // create list of numbers
            List<int> listNums = new List<int>() { 16, 25, 30, 77, 100, 819, 2000, 11500, 15115, 2001234 };

            try
            {
                // prompt user to enter a number
                Console.WriteLine("Enter a number: ");
                int userNum = Convert.ToInt32(Console.ReadLine()); // convert user input from string to integer

                // iterate through list, dividing each index value by the user's selected number
                foreach (int listNum in listNums)
                {
                    int quotient = listNum / userNum; // divide list index value by user input. Assign to new variable
                    Console.WriteLine("\n" + listNum + " divided by " + userNum + " equals " + quotient);
                }
            }
            catch (FormatException) // this catches non integer input and displays custom error message
            {
                Console.WriteLine("This program only accepts whole numbers.");
                Console.ReadLine();
                return;
            }
            catch (DivideByZeroException) // this catches user input of 0 and displays custom error message
            {
                Console.WriteLine("Zero is not a valid entry.");
                Console.ReadLine();
                return;
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            Console.WriteLine("\n\n...and the program continues on...");
            Console.ReadLine();
        }
    }
}
