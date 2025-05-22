int totalRows = int.Parse(Console.ReadLine());
char[,] matrix = new char[totalRows, totalRows];

for (int row = 0; row < totalRows; row++)
{
    string input = Console.ReadLine();

    for (int col = 0; col < totalRows; col++)
    {
        matrix[row, col] = input[col];
    }
}

char searchedSymbol = char.Parse(Console.ReadLine());

for (int row = 0; row < totalRows; row++)
{

    for (int col = 0; col < totalRows; col++)
    {
        if (matrix[row, col] == searchedSymbol)
        {
            Console.WriteLine($"({row}, {col})");
            Environment.Exit(0);
        }
    }
}

Console.WriteLine($"{searchedSymbol} does not occur in the matrix");