int[] cups = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int[] bottles = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int wastedWater = 0;
Queue<int> allCups = new Queue<int>(cups);
Stack<int> allBottles = new Stack<int>(bottles);

while (allCups.Any() && allBottles.Any())
{
    int currentBottle = allBottles.Peek();
    int currentCup = allCups.Peek();

    if (currentBottle - currentCup >= 0)
    {
        allCups.Dequeue();
        allBottles.Pop();
        wastedWater += currentBottle - currentCup;
    }
    else
    {
        int toFill = 0;
        while (true)
        {
            toFill = currentBottle - currentCup;
            allBottles.Pop();
            if (toFill >= 0)
            {
                wastedWater += toFill;
                allCups.Dequeue();
                break;
            }
            currentBottle = allBottles.Peek();
            currentCup = Math.Abs(toFill);
        }
    }
}
if (allCups.Any() == false)
{
    Console.WriteLine($"Bottles: {string.Join(" ", allBottles)}");
    Console.Write($"Wasted litters of water: {wastedWater}");
}
else
{
    Console.WriteLine($"Cups: {string.Join(" ", allCups)}");
    Console.Write($"Wasted litters of water: {wastedWater}");
}