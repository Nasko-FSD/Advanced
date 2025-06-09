int dimensions = int.Parse(Console.ReadLine());
char[,] matrix = new char[dimensions, dimensions];

string[] commands = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

int startingRow = 0;
int startingCol = 0;

populatingMatrix(dimensions, matrix, startingRow, startingCol);
int[] currentStart = findStart(matrix, startingRow, startingCol);


startingRow = currentStart[0];
startingCol = currentStart[1];

checkCommands(dimensions, matrix, commands, ref startingRow, ref startingCol);

totalCoals(matrix, startingRow, startingCol, dimensions);

static void totalCoals(char[,] matrix, int startingRow, int startingCol, int dimensions)
{
    int coalResulst = 0;

    for (int row = 0; row < dimensions; row++)
    {
        for (int col = 0; col < dimensions; col++)
        {
            if (matrix[row, col] == 'c')
            {
                coalResulst++;
            }
        }
    }
    if (coalResulst > 0)
    {
        Console.WriteLine($"{coalResulst} coals left. ({startingRow}, {startingCol})");
    }
    else
    {
        Console.WriteLine($"You collected all coals! ({startingRow}, {startingCol})");
    }
}

int[] findStart(char[,] matrix, int startingRow, int startingCol)
{
    int[] startIndex = new int[2];

    for (int row = 0; row < dimensions; row++)
    {
        for (int col = 0; col < dimensions; col++)
        {
            if (matrix[row, col] == 's')
            {
                startingRow = row;
                startingCol = col;
            }
        }
    }
    startIndex[0] = startingRow;
    startIndex[1] = startingCol;
    return startIndex;
}
static void populatingMatrix(int dimensions, char[,] matrix, int startingRow, int startingCol)
{
    for (int row = 0; row < dimensions; row++)
    {
        char[] input = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(char.Parse)
            .ToArray();

        for (int col = 0; col < dimensions; col++)
        {
            if (input[col] == 's')
            {
                startingRow = row;
                startingCol = col;
            }
            matrix[row, col] = input[col];
        }
    }
}

static void checkCommands(int dimensions, char[,] matrix, string[] commands, ref int startingRow, ref int startingCol)
{
    for (int i = 0; i < commands.Length; i++)
    {
        string currentCommand = commands[i];

        if (currentCommand == "up" &&
            startingRow - 1 >= 0)
        {
            startingRow = startingRow - 1;
        }
        if (currentCommand == "down" &&
            startingRow + 1 < dimensions)
        {
            startingRow = startingRow + 1;
        }
        if (currentCommand == "left" &&
            startingCol - 1 >= 0)
        {
            startingCol = startingCol - 1;
        }
        if (currentCommand == "right" &&
            startingCol + 1 < dimensions)
        {
            startingCol = startingCol + 1;
        }

        if (matrix[startingRow, startingCol] == 'e')
        {
            Console.WriteLine($"Game over! ({startingRow}, {startingCol})");
            Environment.Exit(0);
        }

        if (matrix[startingRow, startingCol] == 'c')
        {
            matrix[startingRow, startingCol] = '*';
        }
    }
}