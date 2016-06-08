using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson5
{
    /**
     * <summary>
     * This is the Student class. It is derived from the Person class
     * </summary>
     * 
     * @class Student
     * @extends Person
     */
    class Student : Person
    {
        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++
        private string _studentID;
        private List<Course> _courses = new List<Course>();

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This property, StudentID, includes a getter and setter for the private
         * instance variable _studentID
         * </summary>
         * 
         * @property StudentID
         */
        public string StudentID
        {
            get
            {
                return _studentID;
            }
            set
            {
                _studentID = value;
            }
        }

        public List<Course> Courses
        {
            get
            {
                return this._courses;
            }
            set
            {
                this._courses = value;
            }
        }

        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This constructor takes three parameters: name, age and studentID
         * </summary>
         * 
         * @class Student
         * @extends Person
         * @param {string} name
         * @param {int} age
         * @param {string} studentID
         */
        public Student(string name, int age, string studentID) : base(name, age)
        {
            this.StudentID = studentID;
        }

        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This method enables the Studies behaviour for the student
         * </summary>
         * 
         * @method Studies
         * @returns {void}
         */
        public void Studies()
        {
            Console.WriteLine(this.Name + " studies.");
        }

        /**
         * <summary>
         * This method lists all the courses the student is currently enrolled in.
         * </summary>
         * 
         * @method ShowCourses
         * @returns {void}
         */
        public void ShowCourses()
        {
            Console.WriteLine();
            Console.WriteLine("Course List");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            foreach (Course course in this._courses)
            {
                Console.WriteLine("+ " + course.Code + " " + course.Description);
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
        }
    }
}
