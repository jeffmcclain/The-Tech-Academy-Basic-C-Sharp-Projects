using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_103
{
    class Program
    {
        static void Main(string[] args)
        {

            // create string array and assign values
            string[] stringArray1 = { "cero", "uno", "dos", "cuatro", "cinco", "seis", "siete" };

            //prompt user to enter text
            Console.WriteLine("Enter some text...");
            string userInput = Console.ReadLine();  // assign user's input to a variable

            // replace a value at index '3' with input variable value
            stringArray1[3] = userInput;

            // iterate through array and print index values to separate lines on console
            for (int i = 0; i < stringArray1.Length; i++)
            {
                Console.WriteLine("-" + stringArray1[i]);
            }





            // this is an infinite loop. Commen-out the first for loop and un-comment the following
            // for loop to correct this issue
            //for (int j = 0; j > -1; j++ )
            //{
            //    Console.WriteLine(j);
            //}

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(j);
            }

            // this for loop iterates through numbers <= 10
            for (int k = -5; k <= 10; k++)
            {
                Console.WriteLine(k);
            }





            // list of unique strings
            List<string> charStrings = new List<string>() { "a", "c", "e", "g", "i", "k", "m", "o", "q", "s", "u", "w", "y" };
            // list for matching characters
            List<string> charMatch = new List<string>();


            //prompt user to enter a single letter
            Console.WriteLine("\n\nEnter a single letter:");
            string userString = Console.ReadLine(); // declare variable and assign user input

            // this for loop iterates through each list entry and returns any index that matches user input
            for (int l = 0; l < charStrings.Count; l++)
            {
                if (charStrings[l] == userString) // check if an index matches user input
                {
                    charMatch.Add(charStrings[l]);
                    Console.WriteLine("-" + charStrings[l]);
                    break; // exit method once the condition has been met
                }
            }

            // check to see if there were any matches. If not, print message
            if (charMatch.Count == 0)
            {
                Console.WriteLine("\n\tYour selection doesn't match any entry within our database.");
            }





            // create list of strings with some duplicate entries
            List<string> housePets = new List<string>() { "cat", "dog", "bird", "cat", "lizard", "dog", "fish", "rat", "fish" };

            // create list to store indicies that match user input
            List<string> petMatch = new List<string>();

            // prompt user to input text
            Console.WriteLine("\n\nEnter a type of common household pet: e.g. dog");
            string userPet = Console.ReadLine(); // declare variable and assign user input

            // this loop iterates through list searching for entries that match user input
            for (int m = 0; m < housePets.Count; m++)
            {
                if (housePets[m] == userPet) // check if an index matches user input
                {
                    petMatch.Add(housePets[m]);
                }
            }

            // check to see if numMatch holds any match values and notify user if there selection doesn't match 
            // an entry within the original list
            if (petMatch.Count == 0)
            {
                Console.WriteLine("\n\tYour selection doesn't match any entry within our database.");
            }

            // print matching pet data to console
            foreach (string m in petMatch)
            {
                Console.WriteLine("-" + m);
            }





            // create list of strings with duplicate entries
            List<string> listNums = new List<string> { "1", "2", "4", "7", "2", "9", "4", "7", "2", "10", "12", "14", "14" };

            // create list to store index strings that match user input
            List<string> numMatch = new List<string>();

            // prompt user to input a selection
            Console.WriteLine("\n\nEnter a number betwee 1-15:");
            string userNum = Console.ReadLine(); // define variable and assign user input

            // this loop iterates through the list searching for any entries that match user input
            foreach (string listNum in listNums)
            {
                if (listNum == userNum)
                {
                    numMatch.Add(listNum); // add matches to new list
                    //break;
                }
            }

            // check to see if numMatch holds any match values and notify user if there selection doesn't match 
            // an entry within the original list
            if (numMatch.Count == 0)
            {
                Console.WriteLine("\n\tYour selection doesn't match any entry within our database.");
            }

            // print the matching data from the new list
            foreach (string o in numMatch)
            {
                Console.WriteLine("-" + o);
            }

            

            Console.ReadLine();
        }
    }
}
