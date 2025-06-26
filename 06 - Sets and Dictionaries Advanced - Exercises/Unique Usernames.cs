HashSet<string> allNames = new HashSet<string>();
int totalNames = int.Parse(Console.ReadLine());

for (int i = 0; i < totalNames; i++)
{
    string inputName = Console.ReadLine();

    allNames.Add(inputName);
}
foreach (string inputName in allNames)
{
    Console.WriteLine(inputName);
}