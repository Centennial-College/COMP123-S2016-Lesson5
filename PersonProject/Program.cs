using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Student tommy = new Student(20, "Tommy", "A123456");

            Console.WriteLine(tommy.ToString());
        }
    }
}
