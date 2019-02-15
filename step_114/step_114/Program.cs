using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_114
{
    class Program
    {
        static void Main(string[] args)
        {

            // declare three variables and assign each a different datatype (integer, decimal and string)
            int wholeNum = 47;
            decimal decimalNum = 25.21m;
            string stringNum = "87";


            // instantiate the class 'Equation' 
            Equation runMethod = new Equation();

            // pass each dataype through the methods. Then print the resulting equations and conversions to console
            runMethod.Math(wholeNum);
            Console.WriteLine("1234 divided by " + wholeNum + " equals " + runMethod.Math(wholeNum));

            runMethod.Math(decimalNum);
            Console.WriteLine("\n150 multiplied by " + decimalNum + " equals " + runMethod.Math(decimalNum));

            runMethod.Math(stringNum);
            Console.WriteLine("\n\"33\" added to " + stringNum + " equals " + runMethod.Math(stringNum));


            Console.ReadLine();
        }
    }
}
