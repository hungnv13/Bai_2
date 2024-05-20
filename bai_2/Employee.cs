using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_2
{
    public class Employee : Person
    {
        public int Salary { get; set; }

        public Employee(string name, string address, int salary) : base(name, address)
        {
            Salary = salary;
        }
 

        public override void Display()
        {
            Console.WriteLine($"Employee Name: {Name}, Address: {Address}, Salary: {Salary}");
        }
    }
}
