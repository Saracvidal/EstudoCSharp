using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionTest
{
    public class Employee
    {
        private string firstName;
        private string lasttName;
        private Date birthDate;
        private Date hireDate;

        public Employee(string firstNameEmployee, string lastNameEmployee, int birthMonth, int birthDay, int birthYear, int hireMonth, int hireDay, int hireYear)
        {
            firstName = firstNameEmployee;
            lasttName = lastNameEmployee;

            birthDate = new Date(birthMonth, birthDay, birthYear);
            hireDate = new Date(hireMonth, hireDay, hireYear);
        }

        public string ToEmployeeString()
        {
            return lasttName + ", " + firstName + " Hired: " + hireDate.ToDateString() + " | Birthday: " + birthDate.ToDateString(); 
        }
    }
}
