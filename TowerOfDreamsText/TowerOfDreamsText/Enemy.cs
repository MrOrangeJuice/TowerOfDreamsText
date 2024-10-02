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
        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                damage = value;
            }
        }
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
            nameRand = rand.Next(1, 11);
            switch(nameRand)
            {
                case 1:
                    name = "Slimo";
                    health = rand.Next(2, 4 + enemiesKilled);
                    damage = rand.Next(1, 2 + enemiesKilled);
                    break;
                case 2:
                    name = "Cannon Gizmo";
                    health = rand.Next(3, 5 + enemiesKilled);
                    damage = rand.Next(1, 2 + enemiesKilled);
                    break;
                case 3:
                    name = "Gravitra";
                    health = rand.Next(2, 4 + enemiesKilled);
                    damage = rand.Next(2, 3 + enemiesKilled);
                    break;
                case 4:
                    name = "Barrollo";
                    health = rand.Next(1, 3 + enemiesKilled);
                    damage = rand.Next(3, 5 + enemiesKilled);
                    break;
                case 5:
                    name = "Tank Gizmo";
                    health = rand.Next(3, 5 + enemiesKilled);
                    damage = rand.Next(3, 5 + enemiesKilled);
                    break;
                case 6:
                    name = "Wrenchonimo";
                    health = rand.Next(2, 4 + enemiesKilled);
                    damage = rand.Next(3, 5 + enemiesKilled);
                    break;
                case 7:
                    name = "Sawblade";
                    health = rand.Next(2, 4 + enemiesKilled);
                    damage = rand.Next(4, 6 + enemiesKilled);
                    break;
                case 8:
                    name = "Beezle";
                    health = rand.Next(5, 8 + enemiesKilled);
                    damage = rand.Next(1, 2 + enemiesKilled);
                    break;
                case 9:
                    name = "Spice Plant";
                    health = rand.Next(2, 4 + enemiesKilled);
                    damage = rand.Next(2, 6 + enemiesKilled);
                    break;
                case 10:
                    health = rand.Next(1, 3 + enemiesKilled);
                    damage = rand.Next(3, 7 + enemiesKilled);
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
            Console.WriteLine(name + " has " + damage + " attack");
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
