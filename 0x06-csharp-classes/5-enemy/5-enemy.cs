using System;
namespace Enemies
{
    /// <summary>
    /// Addition to Zombie class
    /// </summary>
    class Zombie
    {
        int health;
        string name = "(No name)";

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

        public string Name
        {
            /// <summary>
            /// Property Name
            /// </summary>
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {

            return string.Format("Zombie Name: {0} / Total Health: {1}", name, health);
        }
    }
}
