using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_100
{
    class Program
    {
        static void Main(string[] args)
        {


            // create string array and assign some values
            string[] stringArray = { "Apple", "Orange", "Mango", "Pineapple", "Durian", "Banana" };

            // prompt user to enter a number 0-5 to access the corresponding index of the array
            Console.WriteLine("\nWelcome to the mystery fruit machine. Please enter a selection (0-5).");
            int choiceFruit = Convert.ToInt16(Console.ReadLine());   // convert user input from string to an integer

            // check input and notify user if they chose an index that doesn't exist
            if (choiceFruit > 5)
            {
                Console.WriteLine("Your selection doesn't exist!");
            }
            else
            {
                // print to console the index value associated with user's input
                Console.WriteLine("Here's your " + stringArray[choiceFruit]);
            }

            // create integer array and assign values
            int[] intArray = { 15, 2, 777, 1920312, 1, 123, };

            // prompt user to enter a number 0-5 to access the corresponding index of the array
            Console.WriteLine("\n\nEnter a number between 0-5 to receive your new lucky number...");
            int choiceLuckyNum = Convert.ToInt16(Console.ReadLine());   // convert input from string to integer

            // check input and notify user if they chose an index that doesn't exist
            if (choiceLuckyNum > 5)
            {
                Console.WriteLine("Your selection does not exist!");
            }
            else
            {
                //print to console the index value associated with user's input
                Console.WriteLine("Your new lucky number is: " + intArray[choiceLuckyNum]);
            }

            // create string list
            List<string> stringList = new List<string>();
            // add strings to list
            stringList.Add("cat");
            stringList.Add("newt");
            stringList.Add("tiger");
            stringList.Add("panda");
            stringList.Add("llama");
            stringList.Add("capybara");

            // prompt user to enter a number selection
            Console.WriteLine("\n\nNow time to receive your spirit animal. Enter a number 0-5.");
            int choiceSpiritAnim = Convert.ToInt16(Console.ReadLine());

            // check input and notify user if they chose an index that doesn't exist
            if (choiceSpiritAnim> 5)
            {
                Console.WriteLine("Your selection does not exist!");
                Console.ReadLine();
                Environment.Exit(0);    // exit program
            }
            else
            {
                //print to console the index value associated with user's input
                Console.WriteLine("Deep down, you are a " + stringList[choiceSpiritAnim]);
            }


            Console.ReadLine();
        }
    }
}
