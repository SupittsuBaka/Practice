using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFighting.Services
{
    public class FightInfoPrintService
    {
        public FightInfoPrintService()
        {
        }

        public void Print(int round, int health1, int health2)
        {
            if (round != 0)
            {
                Console.WriteLine($"Round {round}!");
            }

            Console.WriteLine($"First fighter HP: {health1}");
            Console.WriteLine($"Second fighter HP: {health2}{Environment.NewLine}");
            if (round == 0)
            {
                Console.WriteLine($"|FIGHT|{Environment.NewLine}");
            }
        }
    }
}
