int totalRows = int.Parse(Console.ReadLine());

int[][] jaggedArray = new int[totalRows][];

for (int row = 0; row < totalRows; row++)
{
    int[] numbers = ParseFromConsole();
    jaggedArray[row] = numbers;
}

string[] readCommands;

while (true)
{
    readCommands = Console.ReadLine()
        .Split();
    string command = readCommands[0];

    if (command != "END")
    {
        int requiredRow = int.Parse(readCommands[1]);
        int requiredCol = int.Parse(readCommands[2]);

        if (requiredRow >= 0 && requiredRow < jaggedArray.Length &&
            requiredCol >= 0 && requiredCol < jaggedArray[requiredRow].Length)
        {
            int value = int.Parse(readCommands[3]);
            switch (command)
            {
                case "Add":
                    jaggedArray[requiredRow][requiredCol] += value;
                    break;

                case "Subtract":
                    jaggedArray[requiredRow][requiredCol] -= value;
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid coordinates");
        }
    }
    if (command == "END")
    {
        break;
    }
}

for (int row = 0; row < jaggedArray.Length; row++)
{
    for (int col = 0; col < jaggedArray[row].Length; col++)
    {
        Console.Write(jaggedArray[row][col] + " ");
    }
    Console.WriteLine();
}

static int[] ParseFromConsole()
{
    return Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
}