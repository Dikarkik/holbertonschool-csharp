using System;
namespace Enemies
{
    /// <summary>
    /// This class defines a zombie.
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// zombie health
        /// </summary>
        public int health;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Constructor using parameters
        /// <param name="value">health</param>
        /// </summary>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");

            health = value;
        }
    }
}
