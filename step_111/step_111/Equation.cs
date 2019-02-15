using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_111
{
    public class Equation
    {
        // create method and pass user input into parameter
        public int Addition(int userNum)
        {
            // declare a new variable to hold the result of the following equation
            int addAnswer = 55 + userNum;
            return addAnswer; // return stored value to the method
        }

        public int Divide(int userNum)
        {
            int divAnswer = 100000 / userNum;
            return divAnswer;
        }

        public int Multiply(int userNum)
        {
            int multAnswer = 5 * userNum;
            return multAnswer;
        }
        
    }
}
