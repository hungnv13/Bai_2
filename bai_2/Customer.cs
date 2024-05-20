using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_2
{
    public class Customer : Person
    {
        public int Balance {  get; set; }

        public Customer(string name, string address, int balance) : base(name , address)
        {
            Balance = balance;
        }

        public override void Display()
        {
            Console.WriteLine($"Customer Name: {Name}, Address: {Address}, Balance: {Balance}");
        }
    }
}
