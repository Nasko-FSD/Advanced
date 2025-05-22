int totalRows = int.Parse(Console.ReadLine());
int[,] matrix = new int[totalRows, totalRows];
int sumDiagonal = 0;
for (int row = 0; row < totalRows; row++)
{
    int[] numbers = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

    for (int col = 0; col < totalRows; col++)
    {
        matrix[row, col] = numbers[col];
    }

    sumDiagonal += matrix[row, row];
}

Console.WriteLine(sumDiagonal);