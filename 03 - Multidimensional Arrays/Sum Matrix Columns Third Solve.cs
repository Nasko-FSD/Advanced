int[] matrixSize = ParseFromConsole(' ', ',');
int row = matrixSize[0];
int col = matrixSize[1];
int[,] matrix = new int[row, col];
int sumCurrentColumn = 0;

for (int rows = 0; rows < row; rows++)
{
    int[] currentRow = ParseFromConsole(' ');

    for (int cols = 0; cols < col; cols++)
    {
        matrix[rows, cols] = currentRow[cols];
    }
}

for (int cols = 0; cols < col; cols++)
{
    for (int rows = 0; rows < row; rows++)
    {
        sumCurrentColumn+= matrix[rows, cols];
    }
    Console.WriteLine(sumCurrentColumn);
    sumCurrentColumn = 0;
}

static int[] ParseFromConsole(params char[] splitSymbols)
{
    return Console.ReadLine()
        .Split(splitSymbols, StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
}