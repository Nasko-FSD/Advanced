double[] input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse)
    .ToArray();

Dictionary<double, int> countedNumbers = new Dictionary<double, int>();

foreach (var number in input)
{
    if (!countedNumbers.ContainsKey(number))
    {
        countedNumbers.Add(number, 0);
    }
    countedNumbers[number]+= 1;
}

foreach (var (key, value) in countedNumbers)
{
    Console.WriteLine($"{key} - {value} times");
}