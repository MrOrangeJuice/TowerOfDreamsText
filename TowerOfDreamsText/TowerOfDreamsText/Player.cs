using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfDreamsText
{
    internal class Player
    {
        private int health;
        public int Health { get { return health; } set { health = value; } }
        private int attack;
        public int Attack { get { return attack; } set { attack = value; } }
        private int thisAttack;
        public int ThisAttack { get { return thisAttack; } set { thisAttack = value; } }
        private int numAttacks;
        public int NumAttacks { get { return numAttacks; } set { numAttacks = value; } }
        private int gems;
        public int Gems { get { return gems; } set { gems = value; } }
        private int critChance;
        public int CritChance { get { return critChance; } set { critChance = value; } }
        private int thisCritChance;
        public int ThisCritChance { get { return thisCritChance; } set { thisCritChance = value; } }
        private int heartChance;
        public int HeartChance { get { return heartChance; } set { heartChance = value; } }
        private int thisHeartChance;
        public int ThisHeartChance { get { return thisHeartChance; } set { thisHeartChance = value; } }

        public Player(int health = 6, int attack = 2, int gems = 0, int critChance = 2, int heartChance = 5)
        {
            this.health = health;
            this.attack = attack;
            this.gems = gems;
            this.critChance = critChance;
            this.heartChance = heartChance;
            thisAttack = 0;
            thisCritChance = 0;
            thisHeartChance = 0;
            numAttacks = 0;
        }
    }
}
