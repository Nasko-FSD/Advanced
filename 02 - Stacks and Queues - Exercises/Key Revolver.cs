int priceBullets = int.Parse(Console.ReadLine());
int sizeBarrel = int.Parse(Console.ReadLine());
int[] bullets = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
Stack<int> allBullets = new Stack<int>(bullets);
int[] locks = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
Queue<int> allLocks = new Queue<int>(locks);
int intelligence = int.Parse(Console.ReadLine());

int usedBullets = 0;
int currentBarrel = sizeBarrel;

while (allBullets.Any() && allLocks.Any())
{

    int currentBullet = allBullets.Pop();
    int currentLock = allLocks.Peek();

    if (currentBullet <= currentLock)
    {
        Console.WriteLine("Bang!");
        allLocks.Dequeue();
    }
    else
    {
        Console.WriteLine("Ping!");
    }

    usedBullets++;
    currentBarrel--;


    if (currentBarrel == 0 && allBullets.Any())
    {
        Console.WriteLine("Reloading!");
        currentBarrel = sizeBarrel;
    }
}

if (allLocks.Any() == false)
{
    int bulletsCost = usedBullets * priceBullets;
    int earned = intelligence - bulletsCost;
    Console.WriteLine($"{allBullets.Count} bullets left. Earned ${earned}");
}
else
{
    Console.WriteLine($"Couldn't get through. Locks left: {allLocks.Count}");
}