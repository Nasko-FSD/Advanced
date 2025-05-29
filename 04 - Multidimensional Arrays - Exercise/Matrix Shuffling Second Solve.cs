int[] dimensions = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

string[,] matrix = ReadMatrix(dimensions[0], dimensions[1]);

while (true)
{
    string[] commandArgs = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);

    string command = commandArgs[0];

    if (command == "END")
    {
        break;
    }

    string[] coordinates = commandArgs.Skip(1).ToArray();

    if (command == "swap" && coordinates.Length == 4)
    {

        int rowOne = int.Parse(commandArgs[1]);
        int colOne = int.Parse(commandArgs[2]);
        int rowTwo = int.Parse(commandArgs[3]);
        int colTwo = int.Parse(commandArgs[4]);

        bool isValidFirstCell = isInRange(matrix, rowOne, colOne);
        bool isValidSecondCell = isInRange(matrix, rowTwo, colTwo);

        if (isValidFirstCell && isValidSecondCell)
        {
            string temp = matrix[rowOne, colOne];
            matrix[rowOne, colOne] = matrix[rowTwo, colTwo];
            matrix[rowTwo, colTwo] = temp;

            PrintMatrix(matrix);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }
}
static void PrintMatrix(string[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col] + " ");
        }
        Console.WriteLine();
    }
}
bool isInRange(string[,] matrix, int rowOne, int colOne)
{
    bool isValid = false;

    if (rowOne >= 0 && rowOne < matrix.GetLength(0) &&
        colOne >= 0 && colOne < matrix.GetLength(1))
    {
        isValid = true;
    }
    return isValid;
}
static string[,] ReadMatrix(int rows, int cols)
{
    string[,] matrix = new string[rows, cols];

    for (int row = 0; row < rows; row++)
    {
        string[] input = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = input[col];
        }
    }
    return matrix;
}