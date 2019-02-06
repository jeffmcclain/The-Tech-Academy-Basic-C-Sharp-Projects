using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_57
{
    class Program
    {
        static void Main()
        {
            // title and program description
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report\n\n");
            //Console.ReadLine();

            // prompt user for info and save to variables with corresponding data type(s)
            Console.WriteLine("What course are you on?");
            string courseTitle = Console.ReadLine();

            Console.WriteLine("\nWhat page are you on?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber); //convert the entered string data to an integer

            Console.WriteLine("\nDo you need help with anything? Please answer \"true\" or \"false\".");
            string helpRequest = Console.ReadLine();
            bool helpReq = Convert.ToBoolean(helpRequest); //convert the entered string data to a boolean value

            Console.WriteLine("\nWere there any positive experiences you\'d like to share? Please give specifics.");
            string posExp = Console.ReadLine();

            Console.WriteLine("\nIs there any other feedback you\'d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("\nHow many hours did you study today?");
            string studyHours = Console.ReadLine();
            int studyHrs = Convert.ToInt32(studyHours); //convert the entered string data to an integer

            Console.WriteLine("\n\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!!");

            Console.ReadLine();
            
            

        }
    }
}
