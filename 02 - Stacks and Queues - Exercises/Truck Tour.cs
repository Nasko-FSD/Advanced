﻿int n = int.Parse(Console.ReadLine());
Queue<int[]> pumps = new Queue<int[]>();

FillQueue(n, pumps);

int counter = 0;

while (true)
{
    int fuelAmount = 0;
    bool isTrue = true;

    for (int i = 0; i < n; i++)
    {
        int[] currentPump = pumps.Dequeue();

        fuelAmount += currentPump[0];

        if (fuelAmount < currentPump[1])
        {
            isTrue = false;
        }

        fuelAmount -= currentPump[1];

        pumps.Enqueue(currentPump);
    }

    if (isTrue)
    {
        break;
    }
    counter++;

    pumps.Enqueue(pumps.Dequeue());
}
Console.WriteLine(counter);

static void FillQueue(int n, Queue<int[]> pumps)
{
    for (int i = 0; i < n; i++)
    {
        int[] currentPump = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        pumps.Enqueue(currentPump);
    }
}