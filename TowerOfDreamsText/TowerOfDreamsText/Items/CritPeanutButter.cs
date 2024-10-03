using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfDreamsText.Items
{
    internal class CritPeanutButter : PassiveItem
    {
        public CritPeanutButter()
        {
            name = "Crit Peanut Butter";
            description = "Heal by 1 when landing a crit";
            price = 40;
        }

        public override void PassiveEffect(Player player)
        {
            
        }

    }
}
