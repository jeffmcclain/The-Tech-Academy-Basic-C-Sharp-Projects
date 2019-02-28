using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_162
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // create a constant variable
            const string greeting = "Welcome to MadLibs!";

            Console.WriteLine(greeting);
            Console.WriteLine("\nEnter your name...");
            string name = Console.ReadLine();
            Console.WriteLine("\nEnter a place...");
            string place = Console.ReadLine();
            Console.WriteLine("\nEnter a verb...");
            string verb = Console.ReadLine();
            Console.WriteLine("\nEnter a noun...");
            string noun = Console.ReadLine();
            Console.WriteLine("\nEnter an adjective...");
            string adjective = Console.ReadLine();

            // create a variable using the keyword var
            var madLib = new MadLib(name, place, verb, noun, adjective);

            Console.WriteLine("\n\nHello, {0}! Welcome to {1}! A place where you " +
                "can always find a {2} {3} and the skies are always {4}.", madLib.Name, madLib.Place,
                madLib.Verb, madLib.Noun, madLib.Adjective);
            Console.Read();

        }
    }
}
