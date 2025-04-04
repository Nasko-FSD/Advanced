int[] numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Stack<int> stack = new Stack<int>(numbers);

while (true)
{
    string[] command = Console.ReadLine()
        .ToLower()
        .Split();

    if (command[0] == "add")
    {
        stack.Push(int.Parse(command[1]));
        stack.Push(int.Parse(command[2]));
    }
    else if (command[0] == "remove")
    {
        var totalElementsToRemove = int.Parse(command[1]);

        if (stack.Count >= totalElementsToRemove)
        {
            for (int i = 0; i < totalElementsToRemove && stack.Any(); i++)
            {
                stack.Pop();
            }
        }
    }
    else
    {
        break;
    }
}
Console.WriteLine($"Sum: {stack.Sum()}");
