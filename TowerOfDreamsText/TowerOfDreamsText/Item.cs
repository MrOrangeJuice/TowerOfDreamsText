using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfDreamsText
{
    internal abstract class Item
    {
        protected string name;
        public string Name { get { return name; } }
        protected string description;
        public string Description { get { return description; } }
        protected int price;
        public int Price { get { return price; } }
        protected bool active;
    }
}
