using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_129
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        
        // overload '==' operator to compare two objects
        public static bool operator ==(Employee one, Employee two)
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
        public static bool operator !=(Employee one, Employee two)
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


        // implement 'SayName()' method with keyword 'override' in order to access within the abstract class 'Person'
        public override void SayName()
        {
            base.SayName();
        }

        public void Quit()
        {
            Console.WriteLine("ENTER to quit...");
            Console.ReadLine();
        }

        public override bool Equals(object obj)
        {
            var employee = obj as Employee;
            return employee != null &&
                   Id == employee.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }
    }
}
