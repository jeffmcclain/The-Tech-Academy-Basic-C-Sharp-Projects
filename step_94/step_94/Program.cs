using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_94
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt user to enter a number
            Console.WriteLine("Enter a number between 1-100 to begin countodown:");
            sbyte startNum = Convert.ToSByte(Console.ReadLine());

            
            // assign the starting number to the index
            sbyte countdown = startNum;
            bool isZero = countdown == -1;

            // check that the user's number follows the stated requirements
            while (startNum < 0 || startNum > 100)
            {
                Console.WriteLine("You didn't choose a number between 1-100! Better luck next time...");
                Console.ReadLine();
                Environment.Exit(0); // exit the program
            }

            Console.WriteLine("\nCountdown begins...\n");

            // begin the countdown. Loop continues until 'countdown' reaches zero
            do
            {
                // print index to screen
                Console.WriteLine(countdown);
                countdown--;
                // check to see if countdown has reached zero. If so, validate the boolean variable
                if (countdown == -1)
                    isZero = true;
            }
            while (!isZero); // continues loop while false

            Console.Read();


        }
    }
}
