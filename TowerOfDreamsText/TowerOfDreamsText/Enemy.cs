using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfDreamsText
{
    internal class Enemy
    {
        private int health;
        public int Health 
        {
            get 
            {
                return health;
            }
            set 
            { 
                health = value; 
            }
        }
        private int damage;
        private bool elite;
        private int eliteRand;
        private int nameRand;
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Enemy(int enemiesKilled = 0) 
        {
            Random rand = new Random();
            health = rand.Next(2, 4+enemiesKilled);
            damage = rand.Next(1, 2+enemiesKilled);
            nameRand = rand.Next(1, 11);
            switch(nameRand)
            {
                case 1:
                    name = "Slimo";
                    break;
                case 2:
                    name = "Cannon Gizmo";
                    break;
                case 3:
                    name = "Gravitra";
                    break;
                case 4:
                    name = "Barrollo";
                    break;
                case 5:
                    name = "Tank Gizmo";
                    break;
                case 6:
                    name = "Wrenchonimo";
                    break;
                case 7:
                    name = "Sawblade";
                    break;
                case 8:
                    name = "Beezle";
                    break;
                case 9:
                    name = "Spice Plant";
                    break;
                case 10:
                    name = "Cumulonimbo";
                    break;
            }
            eliteRand = rand.Next(1, 5);
            if (eliteRand == 2)
            {
                elite = true;
                name = "Elite " + name;
                damage *= 2;
                health *= 2;
            }
            else elite = false;
            // Print details on enemy creation
            Console.WriteLine("You encounter a " + name + "!");
            Console.WriteLine(name + " has " + health + " health");
            Console.WriteLine();
        }

        public int Attack()
        {
            Console.WriteLine(name + " attacks for " + damage + " damage!");
            return damage;
        }

        public void TakeDamage(int playerDamage)
        {
            Console.WriteLine(name + " takes " + playerDamage + " damage!");
            health -= playerDamage;
            if (health < 0) health = 0;
            Console.WriteLine(name + " has " + health + " health remaining!");
        }

        public bool Die()
        {
            if(health <= 0)
            {
                Console.WriteLine(name + " has perished!");
                Console.WriteLine();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
