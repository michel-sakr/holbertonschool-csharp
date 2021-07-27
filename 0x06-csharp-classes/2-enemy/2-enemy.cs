using System;
namespace Enemies
{
    /// <summary>
    /// Class update
    /// </summary>
    class Zombie
    {
        public int health;

        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Overload constructor
        /// </summary>
        /// <param name="value">amount of health </param>
        public Zombie(int value)
        {
            if (value >= 0)
                health = value;
            else
                throw new ArgumentException("Health must be greater than or equal to 0");
        }
    }
}
