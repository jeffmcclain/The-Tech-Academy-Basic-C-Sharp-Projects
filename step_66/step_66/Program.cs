using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_66
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Math Machine...\n\n\n");

            // prompt user to input a number to be multiplied by 50, and print the results to console
            Console.WriteLine("Enter a number to be multiplied by 50:");
            string inputMultiply = Console.ReadLine();
            ulong inputMult = Convert.ToUInt64(inputMultiply);
            ulong product = 50 * inputMult;
            Console.WriteLine("50 * " + inputMult + " = " + product);

            // prompt user to input a number to be added to 25, and print the results to console
            Console.WriteLine("\n\nEnter a number to be added to 25:");
            string inputAddition = Console.ReadLine();
            ulong inputAdd = Convert.ToUInt64(inputAddition);
            ulong combined = 25 + inputAdd;
            Console.WriteLine("25 + " + inputAdd + " = " + combined);

            // prompt user to input a number to be divided by 12.5, and print the results to console
            Console.WriteLine("\n\nEnter a number to be devided by 12.5:");
            string inputDevision = Console.ReadLine();
            ulong inputDev = Convert.ToUInt64(inputDevision);
            double quotient = inputDev / 12.5;
            Console.WriteLine(inputDev + " / 12.5 " + "= " + quotient);

            // prompt user to input a number, check to see if it's greater than 50 and print boolean value to console
            Console.WriteLine("\n\nEnter a number to determine if it is greater than 50:");
            string inputComparison = Console.ReadLine();
            ulong inputComp = Convert.ToUInt64(inputComparison);
            bool comparison = inputComp > 50;
            Console.WriteLine(comparison);

            // prompt user to input a number to be divided by 7, and print the remainder (using modulus operator)
            Console.WriteLine("\n\nEnter a number to calculate the remainder after divided by 7:");
            string inputModulus = Console.ReadLine();
            int inputMod = Convert.ToInt16(inputModulus);
            int modulus = inputMod % 7;
            Console.WriteLine(modulus);

            Console.ReadLine();
        }
    }
}
