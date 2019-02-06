using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_67
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Anonymous Income Comparison Program\n\n");

            // prompt user to enter the hourly wage for 'Person 1' and store in variable for later use
            Console.WriteLine("Person 1:");
            Console.WriteLine("Hourly rate:");
            float wagePer1 = float.Parse(Console.ReadLine());
            // prompt user to enter the hours worked for 'Person 1' and store in a variable for later use
            Console.WriteLine("\nEnter number of hours worker per week:");
            float hoursPer1 = float.Parse(Console.ReadLine());

            // prompt user to enter the hourly wage for 'Person 2' and store in variable for later use
            Console.WriteLine("\n\nPerson 2:");
            Console.WriteLine("Hourly rate:");
            float wagePer2 = float.Parse(Console.ReadLine());
            // prompt user to enter the hours worked for 'Person 2' and store in a variable for later use
            Console.WriteLine("\nEnter number of hours worker per week:");
            float hoursPer2 = float.Parse(Console.ReadLine());

            // use the wage and hours variables for 'Person 1' to calculate annual salary
            float weeklySalaryPer1 = wagePer1 * hoursPer1;
            float annualSalaryPer1 = weeklySalaryPer1 * 52;
            Console.WriteLine("\n\nAnnual Salary of Person 1: $" + annualSalaryPer1);

            // use the wage and hours variables for 'Person 2' to calculate annual salary
            float weeklySalaryPer2 = wagePer2 * hoursPer2;
            float annualSalaryPer2 = weeklySalaryPer2 * 52;
            Console.WriteLine("\nAnnual Salary of Person 2: $" + annualSalaryPer2);

            // use a boolean statement to compare both annual salaries and determine if 'Person 1' makes more than 'Person 2'
            bool compareSalary = annualSalaryPer1 > annualSalaryPer2;
            Console.WriteLine("\n\nDoes Person 1 make more than Person 2?");
            Console.WriteLine(compareSalary);

       
            Console.ReadLine();
        }
    }
}
