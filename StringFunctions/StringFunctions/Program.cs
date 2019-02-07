using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "The man said, \"Hello\", Jess. \n Hello on a new line. \n \t Hello on a tab";
            //string fileName = @"C:\Users\Jesse"; // the @ allows for '\' without an escape

            //bool trueOrFalse = name.Contains("s"); // checks 'name' variable for an 's' in it's value
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length; // counts character length of variable 'name'

            //name = name.ToUpper(); // converts all characters in variable to uppercase



            //Console.WriteLine(quote);
            //Console.ReadLine();


            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jesse");


            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
