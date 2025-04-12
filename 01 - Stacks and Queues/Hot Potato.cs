List<string> input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

Queue<string> allInput = new Queue<string>(input);


int number = int.Parse(Console.ReadLine());

int currentIndex = 1;

while (allInput.Count > 1)
{
    var currentName = allInput.Dequeue();

    if (currentIndex == number)
    {
        Console.WriteLine($"Removed {currentName}");
        currentIndex = 0;
    }
    else
    {
        allInput.Enqueue(currentName);
    }

    currentIndex++;
}
Console.WriteLine($"Last is {allInput.Dequeue()}");