int[] dimensions = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int[,] matrix = new int[dimensions[0], dimensions[1]];
int biggestSum = 0;
int currentSum = 0;
int[,] biggestMatrix = new int[3, 3];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] input = Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = input[col];
    }
}

for (int row = 0; row < matrix.GetLength(0) - 2; row++)
{
    for (int col = 0; col < matrix.GetLength(1) - 2; col++)
    {
        currentSum+= matrix[row, col] +
                     matrix[row, col + 1] +
                     matrix[row,col + 2] +
                     matrix[row + 1, col] +
                     matrix[row + 1, col + 1] +
                     matrix[row + 1, col + 2] +
                     matrix[row + 2, col] +
                     matrix[row + 2, col + 1] +
                     matrix[row + 2, col + 2];

        if (currentSum > biggestSum)
        {
            biggestSum = currentSum;

            biggestMatrix[0, 0] = matrix[row, col];
            biggestMatrix[0, 1] = matrix[row, col + 1];
            biggestMatrix[0, 2] = matrix[row, col + 2];
            biggestMatrix[1, 0] = matrix[row + 1, col];
            biggestMatrix[1, 1] = matrix[row + 1, col + 1];
            biggestMatrix[1, 2] = matrix[row + 1, col + 2];
            biggestMatrix[2, 0] = matrix[row + 2, col];
            biggestMatrix[2, 1] = matrix[row + 2, col + 1];
            biggestMatrix[2, 2] = matrix[row + 2, col + 2];
        }
        currentSum = 0;
    }
}
Console.WriteLine($"Sum = {biggestSum}");

for (int row = 0; row < biggestMatrix.GetLength(0); row++)
{
    for (int col = 0; col < biggestMatrix.GetLength(1); col++)
    {
        Console.Write($"{biggestMatrix[row, col]} ");
    }
    Console.WriteLine();
}