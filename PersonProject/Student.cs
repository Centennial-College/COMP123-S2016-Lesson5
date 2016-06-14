using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonProject
{
    public class Student : Person
    {
        private string _studentNumber;

        public Student(int age, string name, string studentNumber)
            : base(age, name)
        {
            this.StudentNumber = studentNumber;
        }

        public string StudentNumber
        {
            get
            {
                return this._studentNumber;
            }

            set
            {
                this._studentNumber = value;
            }
        }

        public void Study()
        {
            Console.WriteLine("{0} is studying.", this.Name);
        }

        public override string ToString()
        {
            return string.Format("++++++++++++++++++++++++++++++\n+ Name: {0}\n+ Age:{1}\n+ Student Number: {2}\n+++++++++++++++++++++++++++++++",
                this.Name, this.Age, this.StudentNumber);
        }
    }
}