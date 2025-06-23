SortedDictionary<string, Dictionary<string, double>> allShops = new SortedDictionary<string, Dictionary<string, double>>();

string input = Console.ReadLine();

while (input != "Revision")
{
    string[] inputInfo = input
        .Split(", ", StringSplitOptions.RemoveEmptyEntries);

    string shopName = inputInfo[0];
    string product = inputInfo[1];
    double price = double.Parse(inputInfo[2]);

    if (!allShops.ContainsKey(shopName))
    {
        allShops.Add(shopName, new Dictionary<string, double>());
    }
    
    allShops[shopName][product] = price;

    input = Console.ReadLine();
}
foreach (var shop in allShops)
{
    Console.WriteLine($"{shop.Key}->");
    foreach (var products in shop.Value)
    {
        Console.WriteLine($"Product: {products.Key}, Price: {products.Value}");
    }
}