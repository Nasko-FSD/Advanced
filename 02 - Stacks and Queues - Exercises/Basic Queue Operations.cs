int[] tokens = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int totalNumbers = tokens[0];

int toRemove = tokens[1];

int searchFor = tokens[2];

int[] toEnter = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Queue<int> queue = new Queue<int>(toEnter);

int smallesElement = int.MaxValue;

for (int i = 0; i < toRemove && queue.Any(); i++)
{
    queue.Dequeue();
}

if (queue.Contains(searchFor))
{
    Console.WriteLine("true");
}

else if (queue.Any() == false)
{
    Console.WriteLine("0");
}

else
{
    foreach (var element in queue)
    {
        if (element < smallesElement)
        {
            smallesElement = element;
        }
    }
    Console.WriteLine(smallesElement);
}