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
            // declare variable to store user selected number
            int userNum = 0;

            // create boolean to iterate loop, verifying user selection is a number
            bool notNumber = true;

            while (notNumber)
            {
                try
                {
                    // prompt user to select a number
                    Console.WriteLine("Enter a number:");
                    userNum = Convert.ToInt32(Console.ReadLine());
                    notNumber = false; // exit while loop
                }
                catch (FormatException) // check for input that doesn't meet the required integer format
                {
                    Console.WriteLine("Please enter a whole number..."); // print error message to console
                }
            }
            
            // declare variable string 'numLog' and convert the 'userNum' integer to string
            string numLog = string.Format(Convert.ToString(userNum));
            // log the user selection to the file pathway
            File.WriteAllText(@"C:\Users\Jefe\Desktop\step_154.txt", numLog);
            // read text in file and write to console
            string readLog = File.ReadAllText(@"C:\Users\Jefe\Desktop\step_154.txt");
            Console.WriteLine("\nThe number you selected and logged was {0}.", readLog);
            Console.ReadLine();
        }
    }
}
