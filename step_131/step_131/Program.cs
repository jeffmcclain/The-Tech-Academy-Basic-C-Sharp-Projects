using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_129
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate object and assign values to properties 'firstName' and 'lastName'
            Employee<string> name = new Employee<string>();
            name.firstName = "Sample";
            name.lastName = "Student";
            name.Id = 1;
            name.Id = 2;

            // instantiate 'Employee' object with data type string as it's generic parameter
            Employee<string> stringThing = new Employee<string>();
            stringThing.Things = new List<string>() { "thingOne", "ThingTwo", "thingThree", "thingFour" };
            stringThing.PrintThings(stringThing.Things);

            // instantiate 'Employee' object with data type int as it's generic parameter
            Employee<int> intThing = new Employee<int>();
            intThing.Things = new List<int>() { 1, 5, 9, 21, 923, 12340 };
            intThing.PrintThings(intThing.Things);


            // call method 'SayName()' on the object 'name'
            name.SayName();

            // using polymorphism instantiate object of type 'IQuittable' and call the 'Quit()' method
            IQuittable quit = new Employee<IQuittable>();
            quit.Quit();

            Console.ReadLine();
        }
    }
}
