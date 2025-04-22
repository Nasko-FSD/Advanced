Stack<int> stack = new Stack<int>();

int totalQueries = int.Parse(Console.ReadLine());

for (int i = 0; i < totalQueries; i++)
{
    int[] operations = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

    int command = operations[0];

    switch (command)
    {
        case 1:
            stack.Push(operations[1]);
            break;

        case 2:
            if (stack.Any())
            {
                stack.Pop();
            }            
            break;

        case 3:
            if (stack.Any())
            {
                int maxElement = int.MinValue;

                foreach (var element in stack)
                {
                    if (element > maxElement)
                    {
                        maxElement = element;
                    }
                }
                Console.WriteLine(maxElement);
            }
            break;

        case 4:
            if (stack.Any())
            {
                int minElement = int.MaxValue;

                foreach (var element in stack)
                {
                    if (element < minElement)
                    {
                        minElement = element;
                    }
                }
                Console.WriteLine(minElement);
            }
            break;
    }
}

Console.WriteLine(string.Join(", ", stack));