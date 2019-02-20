using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_129
{
    public abstract class Person
    {
        
        // declare properties 'firstName' and 'lastName'
        public string firstName { get; set; }
        public string lastName { get; set; }
        

        // create a method with keyword 'virtual' in order to implement in outside class
        public virtual void SayName()
        {
            Console.WriteLine("Employee: " + firstName + " " + lastName);
        }
    }
}
