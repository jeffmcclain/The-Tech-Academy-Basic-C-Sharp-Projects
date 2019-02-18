using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_117
{
    class Equation
    {
        // create void method that outputs an integer
        public void Divide (int userNumOne)
        {
            int quotient = userNumOne / 2;
            Console.WriteLine("\n" + userNumOne + " divided by 2 equals " + quotient); // print to console
        }

        // create a method with outpout parameter 'answerOut'
        public void Multiply (int userNumOne, out int answerOut, int userNumTwo = 0)
        {
            int productOne = userNumOne * userNumTwo;
            answerOut = productOne; // assign the value of 'productOne' to the out parameter 'answerOut'
        }
        
        // create overload method
        public int Multiply (int userNumOne)
        {
            int product = userNumOne * 5;
            return product;
        }
        
    }
}
