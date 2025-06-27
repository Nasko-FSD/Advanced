Dictionary<string, Dictionary<string, int>> allClothes = new Dictionary<string, Dictionary<string, int>>();
int totalClothes = int.Parse(Console.ReadLine());

for (int i = 0; i < totalClothes; i++)
{
    string[] input = Console.ReadLine()
        .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
    string color = input[0];
    string[] clothes = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

    if (!allClothes.ContainsKey(color))
    {
        allClothes.Add(color, new Dictionary<string, int>());
    }
    foreach (var cloth in clothes)
    {
        if (!allClothes[color].ContainsKey(cloth))
        {
            allClothes[color].Add(cloth, 1);
        }
        else
        {
            allClothes[color][cloth]++;
        }
    }
}
string[] lookFor = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
string checkColor = lookFor[0];
string checkCloth = lookFor[1];

foreach (var (colors, clothes) in allClothes)
{
    Console.WriteLine($"{colors} clothes:");
    foreach (var (cloth, amount) in clothes)
    {
        if (colors == checkColor &&
            cloth == checkCloth)
        {
            Console.WriteLine($"* {cloth} - {amount} (found!)");
        }
        else
        {
            Console.WriteLine($"* {cloth} - {amount}");
        }
    }
}