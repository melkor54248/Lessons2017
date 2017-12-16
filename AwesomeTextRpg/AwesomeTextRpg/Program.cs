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



            Console.ReadLine();

        }
        public static void CreateCharacter(Hero hero )
        {
            Console.WriteLine("What's your character's name");
            hero.Name = Console.ReadLine();
            
            hero.Strength = RollDice(20);
            Console.WriteLine("Your your character's strength is:"+hero.Strength);
            
            hero.Charisma = RollDice(20);
            Console.WriteLine("Your your character's charisma is:" + hero.Charisma);
          
            hero.Intelligence = RollDice(20);
            Console.WriteLine("Your your character's intelligence is:" + hero.Intelligence);
            hero.Wisdom = RollDice(20);
            Console.WriteLine("Your your character's wisdom is:" + hero.Wisdom);


        }
        public static Random diceRoll = new Random();
        public static int RollDice(int number)
        {
       
            return diceRoll.Next(number);
         
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
