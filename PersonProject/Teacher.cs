using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonProject
{
    public class Teacher : Person
    {
        private string _employeeNumber;

        public Teacher(int age, string name, string employeeNumber)
            : base(age, name)
        {
            this.EmployeeNumber = employeeNumber;
        }

        public string EmployeeNumber
        {
            get
            {
                return this._employeeNumber;
            }

            set
            {
                this._employeeNumber = value;
            }
        }

        public void Teach()
        {
            Console.WriteLine("{0} is teaching.", this.Name);
        }
    }
}