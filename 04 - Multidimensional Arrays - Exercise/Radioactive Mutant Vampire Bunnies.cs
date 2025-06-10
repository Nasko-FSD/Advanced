int[] dimensions = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

bool playerWins = false;
bool playerDies = false;
int playerRow = 0;
int playerCol = 0;  

char[,] matrix = new char[dimensions[0], dimensions[1]];

populatingMatrix(dimensions, matrix, ref playerRow, ref playerCol);

char[] allCommands = Console.ReadLine().ToCharArray();

checkCommands(ref playerWins, ref playerDies, ref playerRow, ref playerCol, matrix, allCommands);

void movePlayerLeft(char[,] matrix, ref int playerRow, ref int playerCol)
{
    if (playerCol - 1 >= 0)
    {
        if (matrix[playerRow, playerCol - 1] == 'B')
        {
            matrix[playerRow, playerCol] = '.';
            playerCol -= 1;
            playerDies = true;
        }
        else
        {
            matrix[playerRow, playerCol] = '.';
            matrix[playerRow, playerCol - 1] = 'P';
            playerCol -= 1;
        }
    }
    else
    {
        matrix[playerRow, playerCol] = '.';
        playerWins = true;
    }
}

void movePlayerDown(char[,] matrix, ref int playerRow, ref int playerCol)
{
    if (playerRow + 1 < matrix.GetLength(0))
    {
        if (matrix[playerRow + 1, playerCol] == 'B')
        {
            matrix[playerRow, playerCol] = '.';
            playerRow += 1;
            playerDies = true;
        }
        else
        {
            matrix[playerRow, playerCol] = '.';
            matrix[playerRow + 1, playerCol] = 'P';
            playerRow += 1;
        }
    }
    else
    {
        matrix[playerRow, playerCol] = '.';
        playerWins = true;
    }
}

void movePlayerRight(char[,] matrix, ref int playerRow, ref int playerCol)
{
    if (playerCol + 1 < matrix.GetLength(1))
    {
        if (matrix[playerRow ,playerCol + 1] == 'B')
        {
            matrix[playerRow, playerCol] = '.';
            playerCol += 1;
            playerDies = true;
        }
        else
        {
            matrix[playerRow, playerCol] = '.';
            matrix[playerRow, playerCol + 1] = 'P';
            playerCol += 1;
        }
    }
    else
    {
        matrix[playerRow, playerCol] = '.';
        playerWins = true;
    }
}

void printMatrix(char[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col]);
        }
        Console.WriteLine();
    }
}

void moveBunnies(char[,] matrix, ref int playerRow, ref int playerCol)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    char[,] copy = (char[,])matrix.Clone();

    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            if (copy[row, col] == 'B')
            {
                if (row - 1 >= 0)
                {
                    if (matrix[row - 1, col] == 'P')
                    {
                        playerDies = true;
                    }
                    matrix[row - 1, col] = 'B';
                }
                if (col + 1 < cols)
                {
                    if (matrix[row, col + 1] == 'P')
                    {
                        playerDies = true;
                    }
                    matrix[row, col + 1] = 'B';
                }
                if (row + 1 < rows)
                {
                    if (matrix[row + 1, col] == 'P')
                    {
                        playerDies = true;
                    }
                    matrix[row + 1, col] = 'B';
                }
                if (col - 1 >= 0)
                {
                    if (matrix[row, col - 1] == 'P')
                    {
                        playerDies = true;
                    }
                    matrix[row, col - 1] = 'B';
                }
            }
        }
    }
}

void movePlayerUp(char[,] matrix, ref int playerRow, ref int playerCol)
{
    if (playerRow - 1 >= 0)
    {
        if (matrix[playerRow - 1, playerCol] == 'B')
        {
            matrix[playerRow, playerCol] = '.';
            playerRow -= 1;
            playerDies = true;
        }
        else
        {
            matrix[playerRow - 1, playerCol] = 'P';
            matrix[playerRow, playerCol] = '.';
            playerRow -= 1;
        }
    }
    else
    {
        matrix[playerRow, playerCol] = '.';
        playerWins = true;
    }
}

static void populatingMatrix(int[] dimensions, char[,] matrix, ref int playerRow, ref int playerCol)
{
    for (int row = 0; row < dimensions[0]; row++)
    {
        char[] input = Console.ReadLine().ToCharArray();

        for (int col = 0; col < dimensions[1]; col++)
        {
            if (input[col] == 'P')
            {
                playerRow = row;
                playerCol = col;
            }
            matrix[row, col] = input[col];
        }
    }
}

void checkCommands(ref bool playerWins, ref bool playerDies, ref int playerRow, ref int playerCol, char[,] matrix, char[] allCommands)
{
    for (int i = 0; i < allCommands.Length; i++)
    {
        char currentCommand = allCommands[i];

        if (currentCommand == 'U')
        {
            movePlayerUp(matrix, ref playerRow, ref playerCol);
        }
        else if (currentCommand == 'R')
        {
            movePlayerRight(matrix, ref playerRow, ref playerCol);
        }
        else if (currentCommand == 'D')
        {
            movePlayerDown(matrix, ref playerRow, ref playerCol);
        }
        else if (currentCommand == 'L')
        {
            movePlayerLeft(matrix, ref playerRow, ref playerCol);
        }

        moveBunnies(matrix, ref playerRow, ref playerCol);

        if (playerWins)
        {
            printMatrix(matrix);
            Console.WriteLine($"won: {playerRow} {playerCol}");
            return; 
        }
        if (playerDies)
        {
            printMatrix(matrix);
            Console.WriteLine($"dead: {playerRow} {playerCol}");
            return; 
        }
    }
}