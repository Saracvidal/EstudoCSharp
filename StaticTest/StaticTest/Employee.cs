using System;
using System.Collections.Generic;
using System.Text;

namespace StaticTest
{
    public class Employee
    {
        private string firstName;
        private string lastName;
        private static int count;

        public Employee()
        {

        }

        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;

            ++count;

            Console.WriteLine("Employee object constructor: " + firstName + " " + lastName + ", Count = " + Count);
        }

        //Destructor decrements Employee static count
        ~Employee()
        {
            --count;
            Console.WriteLine("Employee object destructor: " + firstName + " " + lastName + ", Count = " + Count);
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
        }

        public static int Count
        {
            get
            {
                return count;
            }
        }
    }
}
