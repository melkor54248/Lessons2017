using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> persons = new List<Person>();

            while (true)
            {
                string nameFromUser = Console.ReadLine();
                if(nameFromUser == "e")
                {
                    break;
                }

                var person = new Person();
                person.ReadPerson();
                persons.Add(person);
            }


            foreach(var person in persons)
            {
                person.Epidoma();
            }

            Console.ReadLine();
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public List<Person> Children { get; set; } = new List<Person>();

        public void ReadPerson()
        {
            FirstName = Console.ReadLine();
            LastName = Console.ReadLine();
            int numberOfChilds = Convert.ToInt32(Console.ReadLine());

            for(var i=0; i < numberOfChilds; i++)
            {
                var child = new Person();
                child.ReadPerson();
                Children.Add(child);
            }
        }

        public void DisplayPerson()
        {
            Console.WriteLine($"{FirstName} {LastName}");
            foreach(var child in Children)
                Console.WriteLine($"\t{child.FirstName} {child.LastName}");
        }

        public void Epidoma()
        {
            decimal epidoma = 100m;
            Console.WriteLine(epidoma * Children.Count);
        }
    }


}
