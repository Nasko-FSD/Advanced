int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Queue<int> allNumbers = new Queue<int>(numbers);

for (int i = 0; i < allNumbers.Count; i++)
{
    if (allNumbers.Peek() % 2 == 0)
    {
        allNumbers.Enqueue(allNumbers.Dequeue());
    }
    else
    {
        allNumbers.Dequeue();
        i--;
    }
}

Console.WriteLine(string.Join(", ", allNumbers));