using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace step_154
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("The current time is {0}.", currentTime);

            // declare variable to store user selected number
            int userNum = 0;

            // create boolean to iterate loop, verifying user selection is a number
            bool notNumber = true;

            while (notNumber)
            {
                try
                {
                    // prompt user to select a number
                    Console.WriteLine("\nEnter a number:");
                    userNum = Convert.ToInt32(Console.ReadLine());
                    notNumber = false; // exit while loop
                }
                catch (FormatException) // check for input that doesn't meet the required integer format
                {
                    Console.WriteLine("\nPlease enter a whole number..."); // print error message to console
                }
            }
            // add 'userNum' (as hours) to the current time and assign value to new variable 'addHours'
            DateTime addHours = DateTime.Now.AddHours(userNum);
            // calculate the exact time (in hours) it will adding the user selected number to current datetime
            Console.WriteLine("\nIt will be {0}, in {1} hours.", addHours, userNum);
            Console.ReadLine();
        }
    }
}
