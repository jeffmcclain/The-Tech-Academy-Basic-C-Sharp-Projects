using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_115
{
    class Equation
    {
        // this method has two parameters, one of which is optional, and return a value
        public int Addition(int inputOne, int inputTwo = 0)
        {
            
            int addAnswer = inputOne + inputTwo;
            return addAnswer;
        }
    }
}
