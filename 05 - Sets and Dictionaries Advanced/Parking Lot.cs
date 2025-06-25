HashSet<string> allCars = new HashSet<string>();

string input = Console.ReadLine();

while (input != "END")
{
    string[] inputInfo = input
        .Split(", ", StringSplitOptions.RemoveEmptyEntries);
    string direction = inputInfo[0];
    string carNumber = inputInfo[1];

    if (direction == "IN")
    {
        allCars.Add(carNumber);
    }
    else
    {
        allCars.Remove(carNumber);
    }

    input = Console.ReadLine();
}
if (allCars.Count > 0)
{
    foreach (var number in allCars)
    {
        Console.WriteLine(number);
    }
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}