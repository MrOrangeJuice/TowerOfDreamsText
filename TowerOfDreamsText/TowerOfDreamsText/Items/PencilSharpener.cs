using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfDreamsText.Items
{
    internal class PencilSharpener : PassiveItem
    {
        public PencilSharpener()
        {
            name = "Pencil Sharpener";
            description = "+1 attack damage";
            price = 50;
        }

        public override void PassiveEffect(Player player)
        {
            player.ThisAttack += 1;
        }
    }
}
