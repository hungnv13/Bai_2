using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee("HuyTT", "Ha Noi", 50000),
                new Employee("HuyQO", "Ha Noi", 60000),
                new Employee("Hungnv", "Vinh Phuc", 60000)
            };
            List<Customer> customers = new List<Customer>
            {
                new Customer("Duy", "Nam Dinh", 1500),
                new Customer("Hailt", "Ha Tinh", 500)
            };

            Console.WriteLine("Employess: ");
            employees.ForEach(e => e.Display());

            Console.WriteLine("\nCustomers: ");
            customers.ForEach(c => c.Display());

            var highestPaidEmployee = FindHighestPaidEmployee(employees);
            Console.WriteLine("\nHighest Paid Employee:");
            highestPaidEmployee.Display();

            var customerWithLowestBalance = FindCustomerWithLowestBalance(customers);
            Console.WriteLine("\nCustomer with Lowest Balance:");
            customerWithLowestBalance.Display();

            Console.WriteLine("\nEnter employee name to search:");
            string searchName = Console.ReadLine();
            var searchedEmployee = FindEmployeeByName(employees, searchName);
            if (searchedEmployee != null)
            {
                Console.WriteLine("\nFound Employee:");
                searchedEmployee.Display();
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }

            try
            {
                Console.WriteLine("\nEnter new employee name:");
                string newName = Console.ReadLine();
                Console.WriteLine("Enter new employee address:");
                string newAddress = Console.ReadLine();
                Console.WriteLine("Enter new employee salary:");
                int newSalary = int.Parse(Console.ReadLine());
                employees.Add(new Employee(newName, newAddress, newSalary));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number for salary.");
            }
        }

        static Employee FindHighestPaidEmployee(List<Employee> employees) =>
            employees.Count == 0 ? null : employees.OrderByDescending(e => e.Salary).FirstOrDefault();

        static Customer FindCustomerWithLowestBalance(List<Customer> customers) =>
            customers.Count == 0 ? null : customers.OrderBy(c => c.Balance).FirstOrDefault();

        static Employee FindEmployeeByName(List<Employee> employees, string name) =>
            employees.FirstOrDefault(e => e.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }
}
