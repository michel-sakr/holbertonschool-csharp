using System;
namespace Enemies
{
    /// <summary>
    /// Addition to Zombie class
    /// </summary>
    class Zombie
    {
        int health; //private variable
        string name = "(No name)"; //private variable

        /// <summary>
        /// Conatructor
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Overload
        /// </summary>
        /// <param name="value">health points</param>
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
        /// <returns> health</returns>
        public int GetHealth()
        {
            return health;
        }

        /// <summary>
        /// Property
        /// </summary>
        /// <value>input from user</value>
        public string Name
        {
            /// <summary>
            /// Property Name
            /// </summary>
            get { return name; }
            set { name = value; }
        }


    }
}
