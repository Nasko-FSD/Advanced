int[] matrixSize = ParseFromConsole(' ', ',');
int row = matrixSize[0];
int col = matrixSize[1];
int[,] matrix = new int[row, col];
int currentSum = 0;
int startRow = 0;
int startCol = 0;
int maxSum = int.MinValue;

for (int rows = 0; rows < row; rows++)
{
    int[] currentRow = ParseFromConsole(' ');

    for (int cols = 0; cols < col; cols++)
    {
        matrix[rows, cols] = currentRow[cols];
    }
}

for (int rows = 0; rows < row - 1; rows++)
{
    for (int cols = 0; cols < col - 1; cols++)
    {        
        currentSum = matrix[rows, cols] +
            matrix[rows, cols + 1] +
            matrix[rows + 1, cols] +
            matrix[rows + 1, cols + 1];

        if (currentSum > maxSum)
        {
            maxSum = currentSum;
            startRow = rows;
            startCol = cols;
        }
    }
}

Console.WriteLine($"{matrix[startRow, startCol]} {matrix[startRow, startCol + 1]}");
Console.WriteLine($"{matrix[startRow + 1, startCol]} {matrix[startRow + 1, startCol + 1]}");
Console.WriteLine(maxSum);

static int[] ParseFromConsole(params char[] splitSymbols)
{
    return Console.ReadLine()
        .Split(splitSymbols, StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
}