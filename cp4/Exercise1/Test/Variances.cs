using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Person {
        public string? Name { get; set; } 
    }

    public class Employee : Person {
        public int Id { get; set; }
    }

    public class PersonEqual : IEqual<Person> {
        public bool Equals(Person a, Person b) {
            return a.Name == b.Name;
        }
    }

    public class EmployeeEqual : IEqual<Employee>
    {
        public bool Equals(Employee a, Employee b)
        {
            return a.Name == b.Name && a.Id == b.Id;
        }
    }

    public class PersonGenerator : IGenerator<Person>
    {
        public Person Generate(int x)
        {
            Person p = new Person();
            p.Name = x.ToString();
            return p;
        }
    }

    public class EmployeeGenerator : IGenerator<Employee>
    {
        public Employee Generate(int x)
        {
            Employee e = new Employee();
            e.Name = x.ToString();
            e.Id = x;
            return e;
        }
    }
    public class PersonCopy : ICopy<Person>
    {
        public Person Copy(Person a)
        {
            Person p = new Person();
            p.Name = a.Name;
            return p;
        }
    }

    public class EmployeeCopy : ICopy<Employee>
    {
        public Employee Copy(Employee a)
        {
            Employee e = new Employee();
            e.Name = a.Name;
            e.Id = a.Id;
            return e;
        }
    }

}
