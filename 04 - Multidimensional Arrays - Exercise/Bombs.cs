int dimensions = int.Parse(Console.ReadLine());

int[,] matrix = new int[dimensions, dimensions];

populatingMatrix(dimensions, matrix);

string[] bombIndexes = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

for (int i = 0; i < bombIndexes.Length; i++)
{
    int[] currentBomb = bombIndexes[i]
        .Split(",", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    int bombRow = currentBomb[0];
    int bombCol = currentBomb[1];


    bool isValid = isInRange(matrix, bombRow, bombCol);

    if (isValid && matrix[bombRow, bombCol] > 0)
    {
        int[,] bombExplode = bombRange(matrix, bombRow, bombCol, dimensions);
    }
}

int[] endResult = aliveCells(dimensions, matrix);

Console.WriteLine($"Alive cells: {endResult[0]}");
Console.WriteLine($"Sum: {endResult[1]}");
printMatrix(dimensions, matrix);

static int[,] bombRange(int[,] matrix, int bombRow, int bombCol, int dimensions)
{

    int bombValue = matrix[bombRow, bombCol];

    if (bombRow - 1 >= 0)
    {
        if (bombCol - 1 >= 0)
        {
            if (matrix[bombRow - 1, bombCol - 1] > 0)
            {
                matrix[bombRow - 1, bombCol - 1] -= bombValue;
            }
        }

        if (matrix[bombRow - 1, bombCol] > 0)
        {
            matrix[bombRow - 1, bombCol] -= bombValue;
        }

        if (bombCol + 1 < dimensions)
        {
            if (matrix[bombRow - 1, bombCol + 1] > 0)
            {
                matrix[bombRow - 1, bombCol + 1] -= bombValue;
            }
        }
    }
    if (bombCol - 1 >= 0)
    {
        if (matrix[bombRow, bombCol - 1] > 0)
        {
            matrix[bombRow, bombCol - 1] -= bombValue;
        }
    }
    matrix[bombRow, bombCol] = 0;

    if (bombCol + 1 < dimensions)
    {
        if (matrix[bombRow, bombCol + 1] > 0)
        {
            matrix[bombRow, bombCol + 1] -= bombValue;
        }
    }

    if (bombRow + 1 < dimensions)
    {
        if (bombCol - 1 >= 0)
        {
            if (matrix[bombRow + 1, bombCol - 1] > 0)
            {
                matrix[bombRow + 1, bombCol - 1] -= bombValue;
            }
        }
        if (matrix[bombRow + 1, bombCol] > 0)
        {
            matrix[bombRow + 1, bombCol] -= bombValue;
        }
        if (bombCol + 1 < dimensions)
        {
            if (matrix[bombRow + 1, bombCol + 1] > 0)
            {
                matrix[bombRow + 1, bombCol + 1] -= bombValue;
            }
        }
    }
    return matrix;
}


bool isInRange(int[,] matrix, int bombRow, int bombCol)
{
    bool isTrue = false;

    if (bombRow >= 0 &&
        bombRow < dimensions &&
        bombCol >= 0 &&
        bombCol < dimensions)
    {
        isTrue = true;
    }

    return isTrue;
}

static int[] readInput()
{
    return Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
}

static void populatingMatrix(int dimensions, int[,] matrix)
{
    for (int row = 0; row < dimensions; row++)
    {
        int[] inputNumers = readInput();

        for (int col = 0; col < dimensions; col++)
        {
            matrix[row, col] = inputNumers[col];
        }
    }
}

static void printMatrix(int dimensions, int[,] matrix)
{
    for (int row = 0; row < dimensions; row++)
    {
        for (int col = 0; col < dimensions; col++)
        {
            Console.Write(matrix[row, col] + " ");
        }
        Console.WriteLine();
    }
}

static int[] aliveCells(int dimensions, int[,] matrix)
{
    int[] completeResult = new int[2];

    for (int row = 0; row < dimensions; row++)
    {
        for (int col = 0; col < dimensions; col++)
        {
            if (matrix[row, col] > 0)
            {
                completeResult[0]++;
                completeResult[1] += matrix[row, col];
            }
        }
    }
    return completeResult;
}