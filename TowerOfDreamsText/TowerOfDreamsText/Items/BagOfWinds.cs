using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TowerOfDreamsText.Items
{
    internal class BagOfWinds : PassiveItem
    {
        public BagOfWinds()
        {
            name = "Bag of Winds";
            description = "25% better chance to jump over enemies";
            price = 30;
        }

        public override void PassiveEffect(Player player)
        {
            player.ThisJumpChance += 5;
        }
    }
}
