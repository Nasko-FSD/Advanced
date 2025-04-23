int totalQuantity = int.Parse(Console.ReadLine());

int[] allOrders = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Queue<int> queue = new Queue<int>(allOrders);

int biggestOrder = int.MinValue;

foreach (var order in allOrders)
{
    if (order > biggestOrder)
    {
        biggestOrder = order;
    }
}

while (queue.Count > 0)
{
    if (totalQuantity >= queue.Peek())
    {
        totalQuantity -= queue.Peek();
        queue.Dequeue();
    }
    else
    {
        break;
    }
}
Console.WriteLine(biggestOrder);

if (queue.Count == 0)
{
    Console.WriteLine("Orders complete");
}
else
{
    Console.Write("Orders left: {0}", string.Join(" ", queue));
}