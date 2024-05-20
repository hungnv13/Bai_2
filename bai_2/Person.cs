using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_2
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public abstract void Display();
    }
}
