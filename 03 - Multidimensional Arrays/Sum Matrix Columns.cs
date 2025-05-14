int[] matrixSize = ParseFromConsole();
int[,] currentMatrix = new int[matrixSize[0], matrixSize[1]];
int columnSum = 0;

for (int rows = 0; rows < currentMatrix.GetLength(0); rows++)
{
    int[] matrixNumbers = ParseFromConsole();

    for (int cols = 0; cols < currentMatrix.GetLength(1); cols++)
    {
        currentMatrix[rows, cols] = matrixNumbers[cols];
    }
}

for (int cols = 0; cols < currentMatrix.GetLength(1); cols++)
{
    for (int rows = 0; rows < currentMatrix.GetLength(0); rows++)
    {
        columnSum+= currentMatrix[rows, cols];
    }
    Console.WriteLine(columnSum);
    columnSum = 0;
}

static int[] ParseFromConsole()
{
    return Console.ReadLine()
        .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
}