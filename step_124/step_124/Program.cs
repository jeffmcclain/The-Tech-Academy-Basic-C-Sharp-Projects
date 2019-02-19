using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_124
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate object and assign values to properties 'firstName' and 'lastName'
            Employee name = new Employee();
            name.firstName = "Sample";
            name.lastName = "Student";

            // call method 'SayName()' on the object 'name'
            name.SayName();

            Console.ReadLine();
        }
    }
}
