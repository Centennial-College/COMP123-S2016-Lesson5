using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonProject
{
    public abstract class Person
    {
        private int _age;
        private string _name;

        public Person(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public int Age
        {
            get
            {
                return this._age;
            }

            set
            {
                this._age = value;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
            }
        }

        public void Speak()
        {
            Console.WriteLine("{0} says hello!", this.Name);
        }
    }
}