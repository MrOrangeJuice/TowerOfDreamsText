using TowerOfDreamsText;

string input = "";
int health = 6;
int attack = 2;
int gems = 0;
Enemy currentEnemy = new Enemy();
int enemiesKilled = 0;
int dropChance;
int jumpFailChance;

while(input != "q")
{
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("a: Attack");
    Console.WriteLine("j: Jump");
    Console.WriteLine("s: See Stats");
    Console.WriteLine("q: Quit");
    input = Console.ReadLine();
    Console.WriteLine();
    switch(input)
    {
        case "a":
            Console.WriteLine("You attack!");
            currentEnemy.TakeDamage(attack);
            if (currentEnemy.Die())
            {
                enemyDrop();
                enemiesKilled++;
                currentEnemy = new Enemy(enemiesKilled);
            }
            else
            {
                Console.WriteLine();
                health -= currentEnemy.Attack();
                Console.WriteLine("You're now at " + health + " health");
                // Check for death
                if (health <= 0) Death();
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
                health -= currentEnemy.Attack();
                Console.WriteLine("You're now at " + health + " health");
                // Check for death
                if (health <= 0) Death();
            }
            currentEnemy = new Enemy(enemiesKilled);
            break;
        case "s":
            Console.WriteLine("You're at " + health + " health");
            Console.WriteLine("You have " + gems + " gems");
            break;
    }
    Console.WriteLine();
}

void enemyDrop()
{
    Random dropRand = new Random();
    dropChance = dropRand.Next(1, 20);

    Console.WriteLine("You found " + dropChance + " gems!");
    gems += dropChance;
    Console.WriteLine("You now have " + gems + " gems!");
    Console.WriteLine();
    if(dropChance < 11)
    {
        Console.WriteLine("You got a heart!");
        health += 2;
        Console.WriteLine("You're now at " + health + " health!");
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
    health = 6;
    attack = 2;
    gems = 0;
    enemiesKilled = 0;
    currentEnemy = new Enemy();
}