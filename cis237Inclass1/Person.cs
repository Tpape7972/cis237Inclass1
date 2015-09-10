using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    class Person
    {
        string firstName;
        string lastname;
        int age;

        public Person()
        {

        }
        // 3 Parameter Constructor
        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastname = lastName;
            this.age = age;
        }
        // Public Method
        public void PrintFullName()
        {
            Console.WriteLine(this.firstName + ' ' + this.lastname);

        }
        // First Name Property
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
    }
}
