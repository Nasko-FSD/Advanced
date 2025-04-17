int[] input = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int toEnter = input[0];

int toPop = input[1];

int searchFor = input[2];


int[] enterNumbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Stack<int> allNumbers = new Stack<int>(enterNumbers);

for (int i = 0; i < toPop && allNumbers.Count > 0; i++)
{
    allNumbers.Pop();
}

if (allNumbers.Contains(searchFor))
{
    Console.WriteLine("true");
}

else if (allNumbers.Count < 1)
{
    Console.WriteLine("0");
}


else
{
    int smallestNumber = int.MaxValue;

    while (allNumbers.Any())
    {
        int currentNumber = allNumbers.Pop();

        if (currentNumber < smallestNumber)
        {
            smallestNumber = currentNumber;
        }    
    }
    Console.WriteLine(smallestNumber);
}