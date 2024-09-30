using TowerOfDreamsText;

string input = "";
int health = 6;
int attack = 2;
int gems = 0;
Enemy currentEnemy = new Enemy();
int enemiesRemaining = 5;

while(input != "q")
{
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("a: Attack");
    Console.WriteLine("b: Block");
    Console.WriteLine("j: Jump");
    Console.WriteLine("q: Quit");
    input = Console.ReadLine();
    switch(input)
    {
        case "a":
            Console.WriteLine("You attack!");
            currentEnemy.TakeDamage(attack);
            if (currentEnemy.Die()) currentEnemy = new Enemy();
            break;
        case "b":
            Console.WriteLine("You block!");
            break;
        case "j":
            Console.WriteLine("You jump over the enemy!");
            break;
    }
    Console.WriteLine();
}