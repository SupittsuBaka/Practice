using System;
using SimpleFighting.Fighters;
using SimpleFighting.Fighters.Warriors;
using SimpleFighting.Arenas;

namespace SimpleFighting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var achillesSonOfPeleus = new Warrior();
            var richardTheLionheart = new Knight();
            var colosseum = new FightingArena();

            var result = colosseum.Fighting(richardTheLionheart, achillesSonOfPeleus);

            if (result)
            {
                Console.WriteLine($"Richard the Lionheart won");
            }
            else
            {
                Console.WriteLine($"Achilles son of Peleus won");
            }
        }
    }
}
