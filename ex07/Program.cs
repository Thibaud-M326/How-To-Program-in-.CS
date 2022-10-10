using System;

namespace My_Awesome_Program
{
    class Wizard
    {
        public string name;
        public string favoriteSpell;
        public int spellSlots;
        public float experience;

        public void CastSpell()
        {
            if (spellSlots > 0)
            {
                Console.WriteLine(name + " casts " + favoriteSpell);
                spellSlots--;
                experience += 0.3f;
            }
            else 
            {
                Console.WriteLine(name + " is out of spell slots.");
            }
        }

        public void Meditate()
        {
            Console.WriteLine(name + " meditate to gain power !");
            spellSlots = 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard01 = new Wizard();
            wizard01.name = "Parry Hopper";
            wizard01.favoriteSpell = "Unexpecto Patronum";
            wizard01.spellSlots = 2;
            wizard01.experience = 0f;

            wizard01.CastSpell();
            wizard01.CastSpell();
            wizard01.CastSpell();
            wizard01.Meditate();
            wizard01.CastSpell();
            wizard01.CastSpell();

            Console.WriteLine(wizard01.name + " gained " + wizard01.experience + " xp");

            Console.ReadKey();
        }
    }
}