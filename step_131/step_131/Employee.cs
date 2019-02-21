using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_129
{
    public class Employee<T> : Person, IQuittable
    {
        public int Id { get; set; } // property with the data type of integer
        public List<T> Things { get; set; } // property of a list with data type generic
        

        // implement 'SayName()' method with keyword 'override' in order to access within the abstract class 'Person'
        public override void SayName()
        {
            base.SayName();
        }

        
        // overload '==' operator to compare two objects
        public static bool operator ==(Employee<T> one, Employee<T> two)
        {
            if (one.Id == two.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Employee<T> one, Employee<T> two)
        {
            if (one.Id != two.Id)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override bool Equals(object obj)
        {
            var employee = obj as Employee<T>;
            return employee != null &&
                   Id == employee.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }

        // loop through the object lists stored within the property 'Things' using generic data type 'T'
        public void PrintThings (List<T> Things)
        {
            foreach (T Thing in Things)
            {
                Console.WriteLine(Thing);
            }
        }


        public void Quit()
        {
            Console.WriteLine("ENTER to quit...");
            Console.ReadLine();
        }
    }
}
