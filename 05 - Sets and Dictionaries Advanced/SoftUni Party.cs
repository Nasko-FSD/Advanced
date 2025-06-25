HashSet<string> allGuests = new HashSet<string>();

string input = Console.ReadLine();

while (input != "PARTY")
{
    allGuests.Add(input);
    input = Console.ReadLine();
}

input = Console.ReadLine();
while (input != "END")
{
    allGuests.Remove(input);
    input = Console.ReadLine();
}

List<string> vipGuests = allGuests
    .Where(guest => char.IsDigit(guest[0]))
    .ToList();

List<string> regularGuests = allGuests
    .Where(guest => !char.IsDigit(guest[0]))
    .ToList();

Console.WriteLine(allGuests.Count);
foreach (var guest in vipGuests)
{
    Console.WriteLine(guest);
}
foreach (var guest in regularGuests)
{
    Console.WriteLine(guest);
}