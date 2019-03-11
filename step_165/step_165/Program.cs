using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_165
{
    class Program
    {
        static void Main(string[] args)
        {

            int userAge;
            bool validInput = false;

            while (!validInput)
            {
                try
                {
                    // ask user for their age
                    Console.WriteLine("Enter your age");
                    //userAge = Convert.ToInt32(Console.ReadLine());
                    userAge = Convert.ToInt32(Console.ReadLine());
                    if (userAge < 1)
                    {
                        // throw error if the input doesn't fulfill the range requirement
                        throw new ArgumentOutOfRangeException("No age's below 1 allowed...");
                    }
                    else
                    {
                        // get the current DateTime
                        DateTime dateTime = DateTime.Now;
                        DateTime birthTime = dateTime.AddYears(-userAge); // get the DateTime minus user's age
                        int birthYear = birthTime.Year; // extract the year value from birthTime
                        Console.WriteLine("\nYou were born in {0}.", birthYear); // print to console user's birth year
                        validInput = true;
                        Console.ReadLine();
                    }
                }
                catch (NotFiniteNumberException) // catch any non-finite whole number entry
                {
                    Console.WriteLine("Please enter a valid whole number...");
                    Console.ReadLine();
                }
                catch (FormatException) // catch an invalid datatype entry
                {
                    Console.WriteLine("Please enter a valid whole number...");
                    Console.ReadLine();
                }
                catch (Exception) // display a general message if exception caused anything else
                {
                    Console.WriteLine("Please enter a valid whole number...");
                    Console.ReadLine();
                }
            }
        }
    }
}
