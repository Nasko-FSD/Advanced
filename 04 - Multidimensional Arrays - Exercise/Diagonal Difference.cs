int totalSize = int.Parse(Console.ReadLine());
int[,] matrix = new int[totalSize, totalSize];
int primaryDiagonal = 0;
int secondaryDiagonal = 0;

for (int row = 0; row < totalSize; row++)
{
    int[] input = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

    for (int col = 0; col < totalSize; col++)
    {
        matrix[row, col] = input[col];

        if (col == totalSize - 1)
        {
            secondaryDiagonal += matrix[row, col - row];
        }
    }
    primaryDiagonal += matrix[row, row];
}
int diffDiagonal = diffDiagonal = Math.Abs(primaryDiagonal - secondaryDiagonal);
Console.WriteLine($"{diffDiagonal}");