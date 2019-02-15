using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_113
{
    class Equation
    {
        // create void method w/ two parameters, execute a math operation w/ one and print to console the other 
        public void Math(int numOne,int numTwo) // pass two integers, by name, into the method
        {
            int answer = 600 * numOne;
            Console.WriteLine("\nSome math stuff just happened in the background..." +
                "your second selected number was---> " + numTwo);
        }


    }
}
