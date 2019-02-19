using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_124
{
    public class Employee : Person, IQuittable
    {
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
    }
}
