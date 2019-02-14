using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_111
{
    public class Equation
    {
        public void Addition()
        {
            int addNum = UserNum;
            int addAnswer = 55 + addNum;
            //return addAnswer;
            Console.WriteLine(addAnswer);
        }

        public void Divide()
        {
            int divideNum = UserNum;
            int divideAnswer = 100000 / divideNum;
            //return divideAnswer;
            Console.WriteLine(divideAnswer);
        }

        public void Multiply()
        {
            int multiplyNum = UserNum;
            int multAnswer = 5 * multiplyNum;
            //return multAnswer;
            Console.WriteLine(multAnswer);
        }

        public int UserNum { get; set; }
    }
}
