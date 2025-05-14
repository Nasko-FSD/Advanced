int[] matrixSize = ParseArrayFromConsole();

int[,] matrix = new int[matrixSize[0], matrixSize[1]];
int totalSum = 0;

for (int row = 0; row < matrixSize[0]; row++)
{
    int[] currentRow = ParseArrayFromConsole();

    for (int col = 0; col < matrixSize[1]; col++)
    {
        matrix[row, col] = currentRow[col];
        totalSum+= matrix[row, col];
    }
}

Console.WriteLine(matrixSize[0]);
Console.WriteLine(matrixSize[1]);
Console.WriteLine(totalSum);

static int[] ParseArrayFromConsole()
=>  Console.ReadLine()
    .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();