using System;

namespace Human
{
    class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        // add a public "getter" property to access health

        // Add a constructor that takes a value to set Name, and set the remaining fields to default values

        // Add a constructor to assign custom values to all fields

        // Build Attack method
        public int getter
        {
            get
            {
                return health;
            }
        }
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        public Human(string name, int str, int intel, int dext, int heal)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dext;
            health = heal;
        }

        public int Attack(Human target)
        {
            target.health = target.health - (5 * this.Strength);
            return target.health;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Human joe = new Human("joe");
            Human jack = new Human("jackl");
            jack.Attack(joe);
            jack.Attack(joe);
            Human jake = new Human("jake", 5, 5, 5, 120);
            jake.Attack(jack);


            Console.WriteLine("Health: " + joe.getter);
            Console.WriteLine("Health: " + jake.getter);
            Console.WriteLine("Health: " + jack.getter);
        }
    }
}
