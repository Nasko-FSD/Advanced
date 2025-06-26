Dictionary<int, int> allNumbers = new Dictionary<int, int>();
int totalInput = int.Parse(Console.ReadLine());

for (int i = 0; i < totalInput; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    if (!allNumbers.ContainsKey(currentNumber))
    {
        allNumbers.Add(currentNumber, 1);
    }
    else
    {
        allNumbers[currentNumber]++;
    }
}
foreach (var (number, count) in allNumbers)
{
    if (count % 2 == 0)
    {
        Console.WriteLine(number);
    }
}