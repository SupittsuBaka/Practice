using SimpleFighting.Fighters;
using SimpleFighting.Services;

namespace SimpleFighting.Arenas
{
    public class FightingArena
    {
        private readonly FightInfoPrintService _fightInfoPrintService = new FightInfoPrintService();

        public bool Fighting(Warrior fighter1, Warrior fighter2)
        {
            var counter = 0;
            _fightInfoPrintService.Print(counter, fighter1.Health, fighter2.Health);
            while (fighter1.IsAlive && fighter2.IsAlive)
            {
                if (counter % 2 == 0)
                {
                    fighter2.TakingDamage(fighter1.Damage);
                }
                else
                {
                    fighter1.TakingDamage(fighter2.Damage);
                }

                counter++;
                _fightInfoPrintService.Print(counter, fighter1.Health, fighter2.Health);
            }

            if (fighter1.IsAlive)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
