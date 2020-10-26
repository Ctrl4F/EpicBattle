using System;

namespace EpicBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] heroes = { "Harry Potter", "Luke Skywalker", "Superman", "Bilbo Baggins", "Lara Croft" };
            string[] villains = { "Voldemort", "Darth Vader", "Souron", "Joker", "Harley Quinn" };

            string hero = GetCharacter(heroes);
            string villain = GetCharacter(villains);
               
            int herohp = GenerateHp();
            int villainhp = GenerateHp();
            Console.WriteLine($"{hero} with {herohp} hp will fight {villain}" + $" {villainhp} hp");

            while (herohp > 0&& villainhp > 0)
            {
                Random rnd = new Random();
                herohp = herohp - rnd.Next(0, 4);
                villainhp = villainhp - rnd.Next(0, 4);
            }
            if(herohp == 0)
            {
                Console.WriteLine("Dark side wins");
            }
            else
            {
                Console.WriteLine("{hero} saves the day");
            }

            

        }
        public static string GetCharacter(string[] array)
        {
            Random rnd = new Random();
            string randomstring = array[rnd.Next(0, array.Length)];
            return randomstring;

        }
        public static int GenerateHp()
        {
            Random rnd = new Random();
            int hp = rnd.Next(5,11);
            return hp;

        }
    }
}
