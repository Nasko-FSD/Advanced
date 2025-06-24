int totalInput = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, List<string>>> allCountries = new Dictionary<string, Dictionary<string, List<string>>>();

for (int i = 0; i < totalInput; i++)
{
    string[] input = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string continent = input[0];
    string country = input[1];
    string city = input[2];

    if (!allCountries.ContainsKey(continent))
    {
        allCountries.Add(continent, new Dictionary<string, List<string>>());
    }
    if (!allCountries[continent].ContainsKey(country))
    {
        allCountries[continent].Add(country, new List<string>());
    }
    allCountries[continent][country].Add(city);
}
foreach (var (continents, countries) in allCountries)
{
    Console.WriteLine($"{continents}:");
    foreach (var (contryName, cities) in countries)
    {
        Console.WriteLine($"{contryName} -> {string.Join(", ", cities)}");
    }
}