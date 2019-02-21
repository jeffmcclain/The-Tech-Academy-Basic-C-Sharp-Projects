using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_134
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            // this bool switches the try/catch loop on/off
            bool tryAgain = true;

            while (tryAgain)
            {
                try
                {
                    // prompt user to enter the current day of the week
                    Console.WriteLine("Enter the current day of the week:");
                    string userInput = Console.ReadLine(); // assign user input to variable 'currentDay' 
                    string dayUpper = userInput.ToUpper(); // convert string to uppercase and assign to variable 'dayUpper'

                    // attempt to convert string to an enum
                    Days day = (Days)Enum.Parse(typeof(Days), dayUpper);

                    Console.WriteLine("\nIt's " + userInput + "! At least, that's what day you think it is...");
                    tryAgain = false; // end loop
                }
                catch (Exception) // catch any input value that doesn't meet requirements
                {
                    Console.WriteLine("\nPlease enter an actual day of the week\n");
                }
            }
            Console.ReadLine();
        }
        // create enum for the days of the week
        public enum Days
        {
            MONDAY,
            TUESDAY,
            WEDNESDAY,
            THURSDAY,
            FRIDAY,
            SATURDAY,
            SUNDAY
        }
    }
}
