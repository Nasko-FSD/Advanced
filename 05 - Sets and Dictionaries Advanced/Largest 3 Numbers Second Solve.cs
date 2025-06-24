int[] inputNumbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int[] sorted = inputNumbers.OrderByDescending(x => x).ToArray();
int totalLength = 3;

if (sorted.Length < totalLength)
{
    totalLength = sorted.Length;
}
for (int i = 0; i < totalLength; i++)
{
    Console.Write(sorted[i] + " ");
}