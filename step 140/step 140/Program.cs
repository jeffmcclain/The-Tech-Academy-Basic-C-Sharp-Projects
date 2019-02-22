using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_140
{
    class Program
    {
        // create a list of +10 employees. First & last name and Id. Min of two with first name 'Joe'
        public static void Main(string[] args)
        {
            Employee employee = new Employee();

            // call 'MethodOne'
            Methods call = new Methods();
            call.MethodOne();

            // call 'MethodTwo'
            call.MethodTwo();

            // call 'MethodThree'
            call.MethodThree();

            //Console.WriteLine();
            Console.ReadLine();
        }
    }
}
