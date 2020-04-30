using System;

namespace Enemies
{
    ///<summary>comment test</summary>
    public class Zombie {

        ///<summary>public int health</summary>
        public int health;

        ///<summary>construction sets health at 0</summary>
        public Zombie() { this.health = 0; }

        ///<summary>constructor takes value as health</summary>
        public Zombie(int value) {
            if (value < 0) { throw new ArgumentException("Health must be greater than or equal to 0"); }

            else { this.health = value ; }
        }
     }
}
