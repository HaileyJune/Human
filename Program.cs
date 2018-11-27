using System;

namespace Human
{
    class Human
    {
        string name;
        int strength;
        int intellegence;
        int dexterity;

        int health;

        public Human(string myName)
        {
            name = myName;
            strength = 3;
            intellegence = 3;
            dexterity = 3;
            health = 100;
        }

        public Human(string myName, int myStrength, int myInt, int myDex, int myHealth)
        {
            name = myName;
            strength = myStrength;
            intellegence = myInt;
            dexterity = myDex;
            health = myHealth;
        }

        public void Attack(Human thisOne)
        {
            // int hurt = 5 * strength;
            Random rand = new Random();
            int hurt = rand.Next(1,5) * strength;
            thisOne.health = thisOne.health - hurt;
            System.Console.WriteLine("{0} attacked {1} for {2} damage.", name, thisOne.name, hurt);
        }

        public void Heal()
        {
            Random rand = new Random();
            int heal = rand.Next(1,5)*intellegence;
            if (health + heal > 100){
                health = 100;
            }
            else
            {
                health = health+heal;
            }
            System.Console.WriteLine("{0} healed themself and is now at {1} health.", name, health);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("June");
            Human human2 = new Human("Jane");
            human1.Attack(human2);
            human2.Heal();
            System.Console.WriteLine();
        }
    }
}
