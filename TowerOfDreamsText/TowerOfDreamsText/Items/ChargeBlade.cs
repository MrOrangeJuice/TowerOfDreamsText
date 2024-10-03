using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TowerOfDreamsText.Items
{
    internal class ChargeBlade : PassiveItem
    {
        public ChargeBlade()
        {
            name = "Charge Blade";
            description = "Double damage for every third attack";
            price = 30;
        }

        public override void PassiveEffect(Player player)
        {
            if (player.NumAttacks % 3 == 0)
            {
                Console.WriteLine("BLADE IS CHARGED!");
                player.ThisAttack *= 2;
            }
        }
    }
}
