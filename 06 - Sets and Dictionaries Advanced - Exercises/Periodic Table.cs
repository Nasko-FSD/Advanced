HashSet<string> names = new HashSet<string>();
int totalRows = int.Parse(Console.ReadLine());

for (int i = 0; i < totalRows; i++)
{
    string[] input = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    foreach (var name in input)
    {
        names.Add(name);
    }
}
names = names
    .OrderBy(x => x)
    .ToHashSet();
Console.WriteLine(string.Join(" ", names));