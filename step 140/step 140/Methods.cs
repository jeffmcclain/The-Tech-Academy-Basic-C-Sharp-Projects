using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_140
{
    public class Methods
    {
        Employee employee = new Employee();
        public List<Person> joeList = new List<Person>();

        public void MethodOne ()
        {
            Console.WriteLine("foreach loop:\n");
            // using a foreach loop, create a new list of employees with first name 'Joe'
            foreach (Person person in employee.Persons)
            {
                if (person.FirstName == "Joe") // check for employees with first name 'Joe'
                {
                    joeList = new List<Person>(); // create new list to hold the Joe
                    joeList.Add(person); // add any Joe to the new list 'joeList'

                    // print joeList list to console
                    Console.WriteLine("ID: " + person.Id + " NAME: " + person.FirstName + " " + person.LastName);
                }
            }
        }

        // using a lambda expression, create a new list of employees with first name 'Joe'
        public void MethodTwo()
        {
            Employee employee = new Employee();
            Console.WriteLine("\n\nlambda Joe:\n");

            // use lambda function 'Where()' to filter list for first name 'Joe'
            List<Person> lambdaJoe = employee.Persons.Where(x => x.FirstName == "Joe").ToList();

            // print lambdaJoe list to console
           foreach (Person person in lambdaJoe)
            {
                Console.WriteLine("ID: " + person.Id + " NAME: " + person.FirstName + " " + person.LastName);
            }

        }

        // using a lambda expression, make a list of all employees with an Id numer great than 5
        public void MethodThree()
        {
            Employee employee = new Employee();
            Console.WriteLine("\n\nlambda Id:\n");

            // use lambda function
            List<Person> lambdaId = employee.Persons.Where(y => y.Id > 5).ToList();

            // print lambdaId list to console
            foreach (Person person in lambdaId)
            {
                Console.WriteLine("ID: " + person.Id + " NAME: " + person.FirstName + " " + person.LastName);
            }
        }

    }
}
