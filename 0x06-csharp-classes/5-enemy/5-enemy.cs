using System;

namespace Enemies
{
    ///<summary>comment test</summary>
    public class Zombie {

        ///<summary>private int health</summary>
        private int health;

        ///<summary>construction sets health at 0</summary>
        public Zombie() { this.health = 0; }

        ///<summary>constructor takes value as health</summary>
        public Zombie(int value) {
            if (value < 0) { throw new ArgumentException("Health must be greater than or equal to 0"); }

            else { this.health = value ; }

        }
        ///<summary>name of zombie</summary>
        private string name = "(No name)";
        
        ///<summary>getter and setter for name</summary>
        public string Name {
            get { return name; }
            set { this.name = value;}
        }

        ///<summary>getHealth Method returns health of current zombie requesting</summary>
         public int GetHealth() {
            return this.health;
        }

        ///<summary>.toStringmethod overirde</summary> 
        public override string ToString() {
            return String.Format("Zombie Name: {0} / Total Health: {1}", name, health);
        }

     }
}