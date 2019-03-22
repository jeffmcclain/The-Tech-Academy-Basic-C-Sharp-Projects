using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_248
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }

    public class EmployeeListDb : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
