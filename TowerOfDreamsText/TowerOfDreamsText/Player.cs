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
        private int maxHealth;
        public int MaxHealth { get { return maxHealth; } set { maxHealth = value; } }
        private int attack;
        public int Attack { get { return attack; } set { attack = value; } }
        private int attackRange;
        public int AttackRange { get { return attackRange; } set { attackRange = value; } }
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
        private int jumpChance;
        public int JumpChance { get { return jumpChance; } set { jumpChance = value; } }
        private int thisJumpChance;
        public int ThisJumpChance { get { return thisJumpChance; } set { thisJumpChance = value;  } }

        public Player(int health = 8, int maxHealth = 8, int attack = 2, int attackRange = 2, int gems = 0, int critChance = 2, int heartChance = 5, int jumpChance = 10)
        {
            this.health = health;
            this.maxHealth = maxHealth;
            this.attack = attack;
            this.attackRange = attackRange;
            this.gems = gems;
            this.critChance = critChance;
            this.heartChance = heartChance;
            this.jumpChance = jumpChance;
            thisAttack = 0;
            thisCritChance = 0;
            thisHeartChance = 0;
            numAttacks = 0;
            thisJumpChance = 0;
        }
    }
}
