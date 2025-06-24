int[] inputNumbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

var sorted = inputNumbers.OrderByDescending(x => x).Take(3);

Console.WriteLine(string.Join(" ", sorted));