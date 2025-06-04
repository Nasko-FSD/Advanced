int dimesnsions = int.Parse(Console.ReadLine());

char[,] matrixBoard = new char[dimesnsions, dimesnsions];

int removedKnights = 0;

populatingMatrix(dimesnsions, matrixBoard);

int[,] allMoves = new int[,]
{
    {-2, -1}, {-2, +1}, {-1, -2}, {-1, +2},
    {+1, -2}, {+1, +2}, {+2, -1}, {+2, +1}
};

while (true)
{
    int maxAttacks = 0;
    int maxRow = 0;
    int maxCol = 0;

    for (int row = 0; row < dimesnsions; row++)
    {
        for (int col= 0; col < dimesnsions; col++)
        {
            if (matrixBoard[row, col] != 'K')
            {
                continue;
            }

            int currentAttacks = 0;

            for (int moveIndex = 0; moveIndex < allMoves.GetLength(0); moveIndex++)
            {
                int targetRow = row + allMoves[moveIndex, 0];
                int targetCol = col + allMoves[moveIndex, 1];

                if (isInRange(targetRow, targetCol, dimesnsions) && matrixBoard[targetRow, targetCol] == 'K')
                {
                    currentAttacks++;
                }
            }

            if (currentAttacks > maxAttacks)
            {
                maxAttacks = currentAttacks;
                maxRow = row;
                maxCol = col;
            }
        }
    }

    if (maxAttacks == 0)
    {
        break;
    }

    matrixBoard[maxRow, maxCol] = '0';
    removedKnights++;
}

Console.WriteLine(removedKnights);

bool isInRange(int row, int col, int dimension)
{
    return row >=0 &&
           row < dimesnsions &&
           col >= 0 &&
           col < dimesnsions;
}

static void populatingMatrix(int dimesnsions, char[,] matrixBoard)
{
    for (int row = 0; row < dimesnsions; row++)
    {
        string input = Console.ReadLine();

        for (int col = 0; col < dimesnsions; col++)
        {
            matrixBoard[row, col] = input[col];
        }
    }
}