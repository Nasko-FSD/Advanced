HashSet<int> firstOne = new HashSet<int>();
HashSet<int> secondOne = new HashSet<int>();
int[] setsLength = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
for (int i = 0; i < setsLength[0]; i++)
{
    int inputNumbers = int.Parse(Console.ReadLine());
    firstOne.Add(inputNumbers);
}
for (int i = 0; i < setsLength[1]; i++)
{
    int inputNumbers = int.Parse(Console.ReadLine());
    if (firstOne.Contains(inputNumbers))
    {
        secondOne.Add(inputNumbers);
    }
}
firstOne.RemoveWhere(x => !secondOne.Contains(x));
Console.WriteLine(string.Join(" ", firstOne));