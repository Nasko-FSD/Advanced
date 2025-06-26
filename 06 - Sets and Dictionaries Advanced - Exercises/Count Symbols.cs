List<char> onlyChars = Console.ReadLine()
    .ToCharArray()
    .ToList();

Dictionary<char, int> allChars = new Dictionary<char, int>();

foreach (var symbol in onlyChars)
{
    if (!allChars.ContainsKey(symbol))
    {
        allChars.Add(symbol, 1);
    }
    else
    {
        allChars[symbol]++;
    }
}
foreach (var (symbol, count) in allChars.OrderBy(a => a.Key))
{
    Console.WriteLine($"{symbol}: {count} time/s");
}