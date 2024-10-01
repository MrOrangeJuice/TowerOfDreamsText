using TowerOfDreamsText;
using TowerOfDreamsText.Items;

string input = "";
Enemy currentEnemy = new Enemy();
int enemiesKilled = 0;
int dropChance;
int jumpFailChance;
List<Item> items = new List<Item>();
Player player = new Player();
items.Add(new CritJelly());
items.Add(new CritJelly());
items.Add(new CritJelly());
items.Add(new ChargeBlade());
items.Add(new ChargeBlade());
items.Add(new ChargeBlade());
items.Add(new HeartTrophy());
items.Add(new HeartTrophy());
items.Add(new HeartTrophy());

while(input != "q")
{
    // Setup temp variables
    player.ThisAttack = player.Attack;
    player.ThisCritChance = player.CritChance;
    player.ThisHeartChance = player.HeartChance;
    CheckPassiveItems();

    Console.WriteLine("What would you like to do?");
    Console.WriteLine("a: Attack");
    Console.WriteLine("j: Jump");
    Console.WriteLine("p: See Passive Items");
    Console.WriteLine("s: See Stats");
    Console.WriteLine("q: Quit");
    input = Console.ReadLine();
    Console.WriteLine();
    switch(input)
    {
        case "a":
            player.NumAttacks++;
            Console.WriteLine("You attack!");
            Random critRand = new Random();
            if(critRand.Next(1,20) <= player.ThisCritChance)
            {
                Console.WriteLine("CRITICAL HIT!");
                player.ThisAttack *= 2;
            }
            currentEnemy.TakeDamage(player.ThisAttack);
            if (currentEnemy.Die())
            {
                enemyDrop();
                enemiesKilled++;
                currentEnemy = new Enemy(enemiesKilled);
            }
            else
            {
                Console.WriteLine();
                player.Health -= currentEnemy.Attack();
                Console.WriteLine("You're now at " + player.Health + " health");
                // Check for death
                if (player.Health <= 0) Death();
            }
            break;
        case "j":
            Console.WriteLine("You jump over the " + currentEnemy.Name);
            Console.WriteLine();
            Random jumpRand = new Random();
            jumpFailChance = jumpRand.Next(1, 10);
            if(jumpFailChance < 6)
            {
                Console.WriteLine(currentEnemy.Name + " takes a swipe at you before you can get away!");
                player.Health -= currentEnemy.Attack();
                Console.WriteLine("You're now at " + player.Health + " health");
                // Check for death
                if (player.Health <= 0) Death();
            }
            currentEnemy = new Enemy(enemiesKilled);
            break;
        case "p":
            foreach(PassiveItem item in items)
            {
                item.PrintItem();
            }
            break;
        case "s":
            Console.WriteLine("You're at " + player.Health + " health");
            Console.WriteLine("You have " + player.Gems + " gems");
            break;
    }
    Console.WriteLine();
}

void enemyDrop()
{
    Random dropRand = new Random();
    dropChance = dropRand.Next(1, 20);

    Console.WriteLine("You found " + dropChance + " gems!");
    player.Gems += dropChance;
    Console.WriteLine("You now have " + player.Gems + " gems!");
    Console.WriteLine();
    if(dropChance < 11)
    {
        Console.WriteLine("You got a heart!");
        player.Health += 2;
        Console.WriteLine("You're now at " + player.Health + " health!");
        Console.WriteLine();
    }
}

void Death()
{
    Console.WriteLine();
    Console.WriteLine("You perished!");
    Console.WriteLine("You killed " + enemiesKilled + " enemies!");
    Console.WriteLine("Restarting...");
    Console.WriteLine();
    player = new Player();
    enemiesKilled = 0;
    currentEnemy = new Enemy();
}

void CheckPassiveItems()
{
    foreach (PassiveItem item in items)
    {
        item.PassiveEffect(player);
    }
}