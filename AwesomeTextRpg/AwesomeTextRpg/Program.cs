using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeTextRpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The tower of horrors!!!");
            Hero myHero = new Hero();
           
            CreateCharacter(myHero);
            
            Console.WriteLine("Hello mighty " + myHero.Name);
            Console.WriteLine("The tower of horrors is really cold this time of year...");
            Console.WriteLine("You wake up in your cold cell. Freezing... You feel really sick");
            Console.WriteLine("The guard enters our cell.");
            Console.WriteLine("Confess he shouts.");
            Console.WriteLine("What do you do?");
            Console.WriteLine("Press 1 to confess. Press 2 to try to break your bonds.");
            string answer = Console.ReadLine();
            if (answer == "1")
            { }
            else if (answer == "2")
            {
                if (myHero.Strength > 18)
                { }
                else { }
            }

            //add a dragon here
            Dragoon d;



            Console.ReadLine();

        }
        public static void CreateCharacter(Hero hero )
        {
            Console.WriteLine("What's your character's name");
            hero.Name = Console.ReadLine();
            Console.WriteLine("What's your character's strength (1-20)");
            hero.Strength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's your character's charisma (1-20)");
            hero.Charisma = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's your character's intelligence (1-20)");
            hero.Intelligence = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's your character's wisdom (1-20)");
            hero.Wisdom = Convert.ToInt32(Console.ReadLine());


        }
       
    }
    public class Hero
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int HitPoints { get; set; }

        public int Intelligence { get; set; }
        public int Charisma { get; set; }

        public int Wisdom { get; set; }
        public int Dexterity { get; set; }
        public int Defense { get; set; }



    }
}
