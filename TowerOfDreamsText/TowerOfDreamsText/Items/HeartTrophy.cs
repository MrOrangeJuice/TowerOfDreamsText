using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfDreamsText.Items
{
    internal class HeartTrophy : PassiveItem
    {
        public HeartTrophy()
        {
            name = "Heart Trophy";
            description = "25% more likely for enemies to drop hearts";
            price = 60;
        }

        public override void PassiveEffect(Player player)
        {
            player.ThisHeartChance += 5;
        }
    }
}
