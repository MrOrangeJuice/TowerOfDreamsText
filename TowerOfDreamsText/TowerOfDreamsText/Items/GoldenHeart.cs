using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfDreamsText.Items
{
    internal class GoldenHeart : PassiveItem
    {
        public GoldenHeart()
        {
            name = "Golden Heart";
            description = "+2 Max Health";
            price = 30;
        }

        public override void PassiveEffect(Player player)
        {
            player.ThisMaxHealth += 2;
        }
    }
}
