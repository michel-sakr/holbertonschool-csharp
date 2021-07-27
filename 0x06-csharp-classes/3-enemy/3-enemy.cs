using System;
namespace Enemies
{
    /// <summary>
    /// Class update
    /// </summary>
    class Zombie
    {
        int health; // private field

        /// <summary>
        /// public contructor
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Constructor overload
        /// </summary>
        /// <param name="value">health value</param>
        public Zombie(int value)
        {
            if (value >= 0)
                health = value;
            else
                throw new ArgumentException("Health must be greater than or equal to 0");
        }

        /// <summary>
        /// Getter
        /// </summary>
        /// <returns>health pointss</returns>
        public int GetHealth()
        {
            return health;
        }
    }
}
