namespace SimpleFighting.Fighters
{
    public class Warrior
    {
        public Warrior()
        {
            Health = 50;
            Damage = 5;
        }

        public int Health { get; protected set; }
        public int Damage { get; protected set; }
        public bool IsAlive
        {
            get
            {
                if (Health == 0)
                {
                    return false;
                }

                return true;
            }
        }

        public void TakingDamage(int damage)
        {
            if (Health - damage < 0)
            {
                Health = 0;
            }
            else
            {
                Health -= damage;
            }
        }
    }
}
