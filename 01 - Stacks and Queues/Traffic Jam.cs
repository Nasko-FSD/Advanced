int number = int.Parse(Console.ReadLine());

Queue<string> allInput = new Queue<string>();

var input = Console.ReadLine();

int totalCount = 0;

while (input != "end")
{
    if (input.Contains("green") == false)
    {
        allInput.Enqueue(input.ToString());
    }
    else
    {
        for (int i = 1; i <= number && allInput.Count > 0; i++)
        {
            Console.WriteLine($"{allInput.Dequeue()} passed!");
            totalCount++;
        }
    }

    input = Console.ReadLine();
}
Console.WriteLine($"{totalCount} cars passed the crossroads.");