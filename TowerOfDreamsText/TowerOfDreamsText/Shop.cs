using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfDreamsText
{
    internal class Shop
    {
        private List<Item> shopItems = new List<Item>();
        public List<Item> ShopItems
        {
            get
            {
                return shopItems;
            }
            set
            {
                shopItems = value;
            }
        }
        private Random shopRand;
        private List<string> phraseList = new List<string>
        {
            "There's an item for everything!",
            "Try a critical hit PB&J",
            "Keep doing your best out there buddy",
            "Apply for our rewards card!",
        };
        private string input = "";
        public Shop(List<Item> itemList, Player player, int numItems = 3)
        {
            shopRand = new Random();
            for (int i = 0; i < numItems; i++)
            {
                shopItems.Add(itemList[shopRand.Next(0,itemList.Count)]);
            }
            Console.WriteLine();
            Console.WriteLine("You come across a shop!");
            Console.WriteLine("Welcome to Stamper's Supply!");
            Console.WriteLine();
            while (input != "l")
            {
                Console.WriteLine("Gems: " + player.Gems);
                Console.WriteLine("Items for sale:");
                Console.WriteLine();
                PrintItems();
                Console.WriteLine("t: Talk to Stamper");
                Console.WriteLine("l: Leave");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine();
                input = Console.ReadLine();
                bool itemSelected = false;
                Console.WriteLine();
                int itemInput = 0;
                if(input == "t")
                {
                    TalkToStamper();
                }
                else if (Int32.TryParse(input, out itemInput))
                {
                    for (int i = 0; i < shopItems.Count; i++)
                    {
                        if (itemInput == i)
                        {
                            if (player.Gems >= shopItems[itemInput].Price)
                            {
                                player.Items.Add(Buy(itemInput, player));
                            }
                            else
                            {
                                Console.WriteLine("You can't afford that!");
                            }
                            itemSelected = true;
                        }
                    }
                    if (!itemSelected) Console.WriteLine("What item are you talking about?");
                }
                else if(input != "l" && input != "t")
                {
                    Console.WriteLine("Not a number, try again!");
                }
                Console.WriteLine();
            }
        }

        public Item Buy(int itemIndex, Player player)
        {
            player.Gems -= shopItems[itemIndex].Price;
            Console.WriteLine("Purchased " + shopItems[itemIndex].Name + "!");
            return shopItems[itemIndex];
        }

        public void PrintItems()
        {
            for (int i = 0; i < shopItems.Count; i++)
            {
                Console.WriteLine("Item #" + (i));
                shopItems[i].PrintItem(true);
                Console.WriteLine();
            }
        }

        public void TalkToStamper()
        {
            Console.WriteLine(phraseList[shopRand.Next(0,phraseList.Count)]);
        }

    }
}
