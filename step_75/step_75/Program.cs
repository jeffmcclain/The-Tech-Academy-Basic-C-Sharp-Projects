using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_75
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt user to enter age and assign to a variable
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            //Console.WriteLine(age);

            // prompt user to answer if they've received a DUI and assign to a variable
            Console.WriteLine("\nHave you ever had a DUI? (Please answer with 'true' or 'false')");
            bool dui = Boolean.Parse(Console.ReadLine());
            //Console.WriteLine(dui);

            // prompt user to enter the number of speeding tickets they have and assign to a variable
            Console.WriteLine("\nHow many speeding tickets do you have?");
            int speedTicket = int.Parse(Console.ReadLine());

            // take all of the gathered data and determine if the user qualifies for insurance
            bool qualified = age > 15 && dui == false && speedTicket <= 3;
            Console.WriteLine("\nQualified?\n" + qualified);



            Console.ReadLine();

        }
    }
}
