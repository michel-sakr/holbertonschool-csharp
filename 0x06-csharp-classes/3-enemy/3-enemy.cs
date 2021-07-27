using System;
namespace Enemies
{
    class Zombie
    {
        int health;

        public Zombie()
        {
            health = 0;
        }

        public Zombie(int value)
        {
            if (value >= 0)
                health = value;
            else
                throw new ArgumentException("Health must be greater than or equal to 0");
        }

        public int GetHealth()
        {
            return health;
        }
    }
}
