int[] sizeMatrix = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = sizeMatrix[0];
int cols = sizeMatrix[1];

char[,] matrix = new char[rows, cols];

string input = Console.ReadLine();

Queue<char> snake = new Queue<char>(input);

char symbol;

for (int row = 0; row < rows; row++)
{
    if (row % 2 == 0)
    {
        for (int col = 0; col < cols; col++)
        {
            symbol = snake.Dequeue();
            matrix[row, col] = symbol;
            snake.Enqueue(symbol);
        }
    }
    else
    {
        for (int col = cols - 1; col >= 0; col--)
        {
            symbol = snake.Dequeue();
            matrix[row, col] = symbol;
            snake.Enqueue(symbol);
        }
    }
}

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        Console.Write(matrix[row, col]);
    }
    Console.WriteLine();
}