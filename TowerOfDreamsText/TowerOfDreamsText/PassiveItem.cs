using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfDreamsText
{
    internal abstract class PassiveItem : Item
    {
        public abstract void PassiveEffect(Player player);

        public void PrintItem()
        {
            Console.WriteLine(name);
            Console.WriteLine(description);
            Console.WriteLine();
        }
    }
}
