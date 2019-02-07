using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_97
{
    class Program
    {
        static void Main(string[] args)
        {
            // assign values to string variables to be used in the following code
            string location = "Oregon";
            string season1 = "Winter";
            string season2 = "Spring";
            string season3 = "Summer";
            string season4 = "Fall";
            string weather = "rainy";

            // concatenate three of the variables into one string
            Console.WriteLine("Concatenation of the strings: " + location + "/" + season1 + "/" + weather);

            // convert the following string to uppercase letters
            weather = weather.ToUpper();

            Console.WriteLine(weather);

            // create the StringBuilder
            StringBuilder seasonalStory = new StringBuilder();


            seasonalStory.Append("\n\n\t" + location + " is known for it's beauty and biodiversity amongst a variety of ecosystems.");
            seasonalStory.Append("\nAlso, our great state experiences all four seasons. Each offering it's own distinct qualities..");
            seasonalStory.Append("\n\t" + season1 + ": Cold and " + weather);
            seasonalStory.Append("\n\t\t" + season2 + ": Windy and " + weather);
            seasonalStory.Append("\n\t\t\t" + season3 + ": Beautiful and sunny....and also " + weather);
            seasonalStory.Append("\n\t\t\t\t" + season4 + ": Colorful trees and.............." + weather);
            seasonalStory.Append("\nSo, come to " + location + " and check out the sights!\n\nJust don't use an umbrella.");
            Console.WriteLine(seasonalStory);


            Console.ReadLine();
        }
    }
}
