using TowerOfDreamsText;
using TowerOfDreamsText.Items;

string input = "";
Enemy currentEnemy = new Enemy();
int enemiesKilled = 0;
int dropChance;
int jumpFailChance;
List<Item> items = new List<Item>();
Player player = new Player();
List<Item> itemList = new List<Item> {new CritJelly(), new ChargeBlade(), new HeartTrophy(), new PencilSharpener(), new BagOfWinds()};

while(input != "q")
{
    // Setup temp variables
    player.ThisAttack = player.Attack;
    player.ThisCritChance = player.CritChance;
    player.ThisHeartChance = player.HeartChance;
    player.ThisJumpChance = player.JumpChance;
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
            Random attackRand = new Random();
            player.NumAttacks++;
            // Add attack range to attack
            player.ThisAttack += attackRand.Next(0, player.AttackRange);
            Console.WriteLine("You attack!");
            if(attackRand.Next(1,20) <= player.ThisCritChance)
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
            jumpFailChance = jumpRand.Next(1, 20);
            if(jumpFailChance >= player.ThisJumpChance)
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
            Console.WriteLine("You're at " + player.Health + "/" + player.MaxHealth + " health");
            Console.WriteLine("You have " + player.Gems + " gems");
            Console.WriteLine("You deal " + player.Attack + "-" + (player.Attack + player.AttackRange) + " damage");
            break;
    }
    Console.WriteLine();
}

void enemyDrop()
{
    Random dropRand = new Random();
    dropChance = dropRand.Next(1, 20);

    Console.WriteLine("You found " + dropChance + " gems!");
    player.Gems += (dropChance + (currentEnemy.Damage * 2));
    Console.WriteLine("You now have " + player.Gems + " gems!");
    Console.WriteLine();
    if(dropChance < player.ThisHeartChance)
    {
        Console.WriteLine("You got a heart!");
        player.Health += 2;
        if(player.Health > player.MaxHealth) player.Health = player.MaxHealth;
        Console.WriteLine("You're now at " + player.Health + "/" + player.MaxHealth + " health!");
        Console.WriteLine();
    }
    if(dropChance < 11)
    {
        Item newItem = itemList[dropRand.Next(1, itemList.Count)];
        items.Add(newItem);
        Console.WriteLine("You found a " + newItem.Name + "!");
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
    items = new List<Item>();
}

void CheckPassiveItems()
{
    foreach (PassiveItem item in items)
    {
        item.PassiveEffect(player);
    }
}