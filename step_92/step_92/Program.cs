using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_92
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nWelcome to Package Express. Please follow the instructions below...\n\n\n\n");

            // prompt user to enter package weight
            Console.WriteLine("Enter the weight of your package (lb):");
            float packageWeight = Convert.ToUInt16(Console.ReadLine());
            if (packageWeight > 50) // check to make sure the package doesn't exceed max weight
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day. Press ENTER to exit.");
                Console.ReadLine();
                Environment.Exit(0); // this code exits the program
            }
            
            // prompt user to enter the package width
            Console.WriteLine("\nEnter the package width (in):");
            float packageWidth = Convert.ToUInt16(Console.ReadLine());

            // prompt user to enter the package height
            Console.WriteLine("\nEnter the package height (in):");
            float packageHeight = Convert.ToUInt16(Console.ReadLine());

            // prompt user to enter the package length
            Console.WriteLine("\nEnter the package length (in):");
            float packageLength = Convert.ToUInt16(Console.ReadLine());

            // check to see if dimensions exceed package size limitations
            float dimensions = packageWidth + packageHeight + packageLength;
            if ( dimensions > 50)
            {
                Console.WriteLine("\nPackage too big to be shipped via Package Express. Please press ENTER to exit.");
                Console.ReadLine();
                Environment.Exit(0); //exits program
            }

            // calculate shipping cost quote
            float shippingQuote = (dimensions * packageWeight) / 100;

            // print quote to console
            Console.WriteLine("\nEstimated shipping cost: $" + shippingQuote + "\nThank you.");
            

            Console.ReadLine();
        }
    }
}
