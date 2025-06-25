int totalNames = int.Parse(Console.ReadLine());
HashSet<string> allNames = new HashSet<string>();
for (int i = 0; i < totalNames; i++)
{
    allNames.Add(Console.ReadLine());
}
foreach (var name in allNames)
{
    Console.WriteLine(name);
}