int totalPumps = int.Parse(Console.ReadLine());
Queue<int[]> pumps = new Queue<int[]>();

FillQueue(totalPumps, pumps);

int exactIndex = 0;

while (exactIndex < totalPumps)
{
    bool isTrue = true;
    int fuelAmount = 0;

    foreach (var pump in pumps)
    {
        fuelAmount += pump[0];
        fuelAmount -= pump[1];

        if (fuelAmount < 0)
        {
            isTrue = false;
            break;
        }
    }

    if (isTrue)
    {
        Console.WriteLine(exactIndex);
        return;
    }

    exactIndex++;
    pumps.Enqueue(pumps.Dequeue());
}

static void FillQueue(int totalPumps, Queue<int[]> pumps)
{
    for (int i = 0; i < totalPumps; i++)
    {
        int[] input = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        pumps.Enqueue(input);
    }
}