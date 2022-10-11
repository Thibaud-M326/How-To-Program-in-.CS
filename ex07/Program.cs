﻿using System;

namespace My_Awesome_Program
{
    class Wizard
    {
        public string name;
        public string favoriteSpell;
        private int spellSlots;
        private float experience;

        public static int Count;

        public Wizard(string _name, string _favoriteSpell)
        {
            name = _name;
            favoriteSpell = _favoriteSpell;
            spellSlots = 2;
            experience = 0f;
            
            Count++;
        }


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
            Wizard wizard01 = new Wizard("Parry Hopper", "Expecto Patronum");

            wizard01.CastSpell();

            Wizard wizard02 = new Wizard("Gandalf sprouts", "Abracadabra");

            wizard02.CastSpell();

            Console.WriteLine(Wizard.Count);

            Console.ReadKey();
        }
    }
}