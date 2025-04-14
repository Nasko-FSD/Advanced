var input = Console.ReadLine()
    .Split();

int number = int.Parse(Console.ReadLine());

Queue<string> allInput = new Queue<string>(input);

while (allInput.Count > 1)
{
    for (int i = 1; i < number; i++)
    {
        allInput.Enqueue(allInput.Dequeue());
    }
    Console.WriteLine($"Removed {allInput.Dequeue()}");
}
Console.WriteLine($"Last is {allInput.Dequeue()}");