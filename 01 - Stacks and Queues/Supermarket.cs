int counter = 0;

string names = "";

Queue<string> queue = new Queue<string>();

while ((names = Console.ReadLine()) != "End")
{
    if (names == "Paid")
    {
        foreach (var name in queue)
        {
            Console.WriteLine(name);
        }
        queue.Clear();
        counter = 0;
        continue;
    }

    queue.Enqueue(names);
    counter++;
}
Console.WriteLine($"{counter} people remaining.");