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
            int hurt = 5 * strength;
            thisOne.health = thisOne.health - hurt;
            System.Console.WriteLine("{0} attacked {1} for {2} damage.", name, thisOne.name, hurt);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("June");
            Human human2 = new Human("Jane");
            human1.Attack(human2);
            System.Console.WriteLine();
        }
    }
}
