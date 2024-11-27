using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyTree
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Role { get; set; }	
        public Person(int id, string name, string role) {
            Id = id;
            Name = name;
            Role = role;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Role}";
        }
    }
}