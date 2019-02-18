using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_115
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // prompt user to select a number to input
            Console.WriteLine("Enter a number:");
            int inputOne = Convert.ToInt32(Console.ReadLine());
            

            // prompt user to select and optional second number
            Console.WriteLine("Enter a second number (OPTIONAL): ");
            int inputTwo = Convert.ToInt32(Console.ReadLine());

            

            Equation answer = new Equation();
            answer.Addition(inputOne, inputTwo);


            Console.WriteLine(answer.Addition(inputOne, inputTwo));
            Console.ReadLine();
        }
    }
}
