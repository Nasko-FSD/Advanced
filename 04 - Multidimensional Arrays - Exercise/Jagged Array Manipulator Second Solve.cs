int totalRows = int.Parse(Console.ReadLine());

int[][] jaggedArray = new int[totalRows][];

populatingArray(totalRows, jaggedArray);

analyzingArray(totalRows, jaggedArray);

while (true)
{
    string command = Console.ReadLine();

    if (command == "End")
    {
        break;
    }

    string[] commandArgs = command
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    int currentRow = int.Parse(commandArgs[1]);
    int currentCol = int.Parse(commandArgs[2]);
    int currentvalue = int.Parse(commandArgs[3]);

    if (commandArgs[0] == "Add")
    {
        bool isValid = isInRange(jaggedArray, currentRow, currentCol);

        if (isValid)
        {
            addValue(totalRows, jaggedArray, currentRow, currentCol, currentvalue);
        }
    }
    else if (commandArgs[0] == "Subtract")
    {
        bool isValid = isInRange(jaggedArray, currentRow, currentCol);

        if (isValid)
        {
            subtractValue(totalRows, jaggedArray, currentRow, currentCol, currentvalue);
        }
    }
}

printArray(totalRows, jaggedArray);

bool isInRange(int[][] jaggedArray, int currentRow, int currentCol)
{
    bool isTrue = false;

    if (currentRow >= 0 && currentRow < jaggedArray.Length &&
        currentCol >= 0 && currentCol < jaggedArray[currentRow].Length)
    {
        isTrue = true;
    }
    return isTrue;
}

static void addValue(int totalRows, int[][] jaggedArray, int currentRow, int currentCol, int currentvalue)
{
    jaggedArray[currentRow][currentCol] += currentvalue;
}

static void subtractValue(int totalRows, int[][] jaggedArray, int currentRow, int currentCol, int currentvalue)
{
    jaggedArray[currentRow][currentCol] -= currentvalue;
}

static void populatingArray(int totalRows, int[][] jaggedArray)
{
    for (int row = 0; row < totalRows; row++)
    {
        int[] input = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        jaggedArray[row] = input;
    }
}

static void analyzingArray(int totalRows, int[][] jaggedArray)
{
    for (int row = 0; row < totalRows - 1; row++)
    {
        if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
        {
            for (int col = 0; col < jaggedArray[row].Length; col++)
            {
                jaggedArray[row][col] *= 2;
                jaggedArray[row + 1][col] *= 2;
            }
        }
        else
        {
            for (int col = 0; col < jaggedArray[row].Length; col++)
            {
                jaggedArray[row][col] /= 2;
            }
            for (int col = 0; col < jaggedArray[row + 1].Length; col++)
            {
                jaggedArray[row + 1][col] /= 2;
            }
        }
    }
}

static void printArray(int totalRows, int[][] jaggedArray)
{
    for (int row = 0; row < totalRows; row++)
    {
        for (int col = 0; col < jaggedArray[row].Length; col++)
        {
            Console.Write(jaggedArray[row][col] + " ");
        }
        Console.WriteLine();
    }
}