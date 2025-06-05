int dimensions = int.Parse(Console.ReadLine());

char[,] matrixBoard = new char[dimensions, dimensions];

populatigMatrix(dimensions, matrixBoard);

int attackableKnights = 0;
int maxAttackableKnights = int.MinValue;
int knightRow = 0;
int knightCol = 0;
int totalCount = 0;

while (true)
{
    for (int row = 0; row < dimensions; row++)
    {
        for (int col = 0; col < dimensions; col++)
        {
            if (matrixBoard[row, col] == 'K')
            {
                if (row - 1 >= 0)
                {
                    if (col - 2 >= 0)
                    {
                        if (matrixBoard[row - 1, col - 2] == 'K')
                        {
                            attackableKnights++;
                        }
                    }
                    if (col + 2 < matrixBoard.GetLength(1))
                    {
                        if (matrixBoard[row - 1, col + 2] == 'K')
                        {
                            attackableKnights++;
                        }
                    }
                }
                if (row + 1 < matrixBoard.GetLength(0))
                {
                    if (col - 2 >= 0)
                    {
                        if (matrixBoard[row + 1, col - 2] == 'K')
                        {
                            attackableKnights++;
                        }
                    }
                    if (col + 2 < matrixBoard.GetLength(1))
                    {
                        if (matrixBoard[row + 1, col + 2] == 'K')
                        {
                            attackableKnights++;
                        }
                    }
                }
                if (row - 2 >= 0)
                {
                    if (col - 1 >= 0)
                    {
                        if (matrixBoard[row - 2, col - 1] == 'K')
                        {
                            attackableKnights++;
                        }
                    }
                    if (col + 1 < matrixBoard.GetLength(1))
                    {
                        if (matrixBoard[row - 2, col + 1] == 'K')
                        {
                            attackableKnights++;
                        }
                    }
                }
                if (row + 2 < matrixBoard.GetLength(0))
                {
                    if (col - 1 >= 0)
                    {
                        if (matrixBoard[row + 2, col - 1] == 'K')
                        {
                            attackableKnights++;
                        }
                    }
                    if (col + 1 < matrixBoard.GetLength(1))
                    {
                        if (matrixBoard[row + 2, col + 1] == 'K')
                        {
                            attackableKnights++;
                        }
                    }
                }
            }
            if (attackableKnights > maxAttackableKnights)
            {
                maxAttackableKnights = attackableKnights;
                knightRow = row;
                knightCol = col;
            }
            attackableKnights = 0;
        }
    }
    if (maxAttackableKnights != 0)
    {
        matrixBoard[knightRow, knightCol] = '0';
        maxAttackableKnights = 0;
        totalCount++;
    }
    else
    {
        Console.WriteLine(totalCount);
        break;
    }
}

static void populatigMatrix(int dimensions, char[,] matrixBoard)
{
    for (int row = 0; row < dimensions; row++)
    {
        string input = Console.ReadLine();

        for (int col = 0; col < dimensions; col++)
        {
            matrixBoard[row, col] = input[col];
        }
    }
}