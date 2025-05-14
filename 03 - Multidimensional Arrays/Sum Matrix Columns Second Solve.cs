int[] matrixSize = ParseFromConsole();
int rowsCount = matrixSize[0];
int colsCount = matrixSize[1];

int[,] currentMatrix = new int[rowsCount, colsCount];
int[] columnSums = new int[colsCount];

for (int row = 0; row < rowsCount; row++)
{
    int[] input = ParseFromConsole();

    for (int col = 0; col < colsCount; col++)
    {
        currentMatrix[row, col] = input[col];
        columnSums[col] += input[col]; 
    }
}

foreach (var sum in columnSums)
{
    Console.WriteLine(sum);
}

static int[] ParseFromConsole()
{
    return Console.ReadLine()
        .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
}