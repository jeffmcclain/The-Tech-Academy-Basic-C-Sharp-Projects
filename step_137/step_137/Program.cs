using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_137
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate an object from class 'Number' an assign data type decimal
            Number number = new Number(); 
            number.Amount = 12.358m; // assign a value 

            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
