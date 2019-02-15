using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_114
{
    class Equation
    {
        // create method 'Math', pass in an integer from Main() and return an integer
        public int Math(int wholeNum)
        {
            int answerInt = 1234 / wholeNum;
            return answerInt; // return the stored integer
        }

        public int Math(decimal decimalNum)
        {
            int answerIntTwo = Convert.ToInt32(150 * decimalNum);
            return answerIntTwo;
        }

        public int Math(string stringNum)
        {
            int num3 = Convert.ToInt32(stringNum);
            int answerIntThree = 33 + num3;
            return answerIntThree;
        }
    }
}
