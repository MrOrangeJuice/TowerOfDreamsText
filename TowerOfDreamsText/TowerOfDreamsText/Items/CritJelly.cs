using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfDreamsText.Items
{
    internal class CritJelly : PassiveItem
    {
        public CritJelly() 
        {
            name = "Crit Jelly";
            description = "Crit chance up by 25%";
            price = 40;
        }

        public override void PassiveEffect(Player player)
        {
            player.ThisCritChance += 5;
        }

    }
}
