using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson5
{
    /**
     * This class is the "driver" class for our Program
     * 
     * @class Program
     */
    public class Program
    {
        /**
         * the main method for the driver class Program
         * 
         * @method Main
         * @param {string[]} args
         */
        public static void Main(string[] args)
        {
            // create instance of the Student class
            Student tommy = new Student("Tommy", 20, "S123456789");
            tommy.SaysHello();

            Console.WriteLine();

            tommy.Studies();

            tommy.Courses.Add(new Course("COMP123", "Programming 2"));
            tommy.Courses.Add(new Course("COMP125", "Client-Side Web Development"));
            tommy.Courses.Add(new Course("COMP397", "Web Game Programming"));

            tommy.ShowCourses();

            Console.WriteLine();

            Console.WriteLine(tommy.Courses);

            // create instance of the Teacher class
            Teacher tom = new Teacher("Tom", 47, "T123456789");
            tom.SaysHello();

            Console.WriteLine();

            tom.Teaches();

            List<string> names = new List<string>();

            names.Add("Tom");
            names.Add("Mary");
            names.Add("Rutvik");

            int count = 0;
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");
            foreach (string name in names)
            {
                Console.WriteLine("Name #" + count++ + " " + name);
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");

            List<Card> Deck = new List<Card>();

            CreateDeck(Deck);

        }

        public static void CreateDeck(List<Card> deck)
        {
            string suit = "";
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        suit = "hearts";
                        break;
                    case 1:
                        suit = "clubs";
                        break;
                    case 2:
                        suit = "diamonds";
                        break;
                    case 3:
                        suit = "spades";
                        break;
                }
                for (int face = 1; face < 14; face++)
                {
                    deck.Add(new Card(face, suit));
                }
            }
        }
    }
}
