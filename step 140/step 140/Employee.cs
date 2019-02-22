using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_140
{
    public class Employee
    {
        // create a constructor and add values to the objects 
        public Employee()
        {
            Persons = new List<Person>();
            FirstNames = new List<string>() { "Joe", "Raquel", "Joe", "Daniel", "Sara", 
            "Joe", "Tina", "Joe", "Peter", "Judge"};
            LastNames = new List<string>() { "Johnson", "Mendez", "Wilson", "Levi", "Lopez",
            "Buck", "Daly", "Blane", "Griffin", "Judy" };
            Ids = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // iterate through loop, adding coinciding list values to new list 
            for (int i = 0; i < 10; i++)
            {
                Person person = new Person();
                person.FirstName = FirstNames[i];
                person.LastName = LastNames[i];
                person.Id = Ids[i];
                Persons.Add(person);
            }
        }

        // create properties for first name, last name and id
        public List<string> FirstNames { get; set; }
        public List<string> LastNames { get; set; }
        public List<int> Ids { get; set; }
        // create property for the full employee list constructor
        public List<Person> Persons { get; set; }
    }
}
