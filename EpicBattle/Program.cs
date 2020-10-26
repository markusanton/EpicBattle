using Microsoft.VisualBasic;
using System;
using System.Collections;

namespace EpicBattles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] heroes = { "Harry Potter", "Päts", "Mina", "Mart Helme", "Kersti Kaljulaid" };
            string[] villains = { "Andrus Ansip", "Ossinovski", "Mart Laar", "Edgar Savisaar", "Ansip2" };
            
            string hero = GetCharacter(heroes);
            string villain = GetCharacter(villains);
            
            Console.WriteLine($"{hero} will fight {villain}");

            int heroHP = RandomHP();
            int villainHP = RandomHP();
            Console.WriteLine($"Hero HP: {heroHP}, Villain HP: {villainHP}");

            while (heroHP > 0 && villainHP > 0)
            {
                Random rand = new Random();
                heroHP = heroHP - rand.Next(0, 4);
                villainHP = villainHP - rand.Next(0, 4);
            }

            if (heroHP == 0)
            {
                Console.WriteLine("Villain wins!");
            }
            else
            {
                Console.WriteLine("Hero wins!");
            }
        }
        public static string GetCharacter(string[] array)
        {
            Random rand = new Random();
            string randomString = array[rand.Next(0, array.Length)];
            return randomString;
        }
        public static int RandomHP()
        {
            Random rand = new Random();
            int HP = rand.Next(5, 11);
            return HP;
        }
    }
}
