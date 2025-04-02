List<int> inputIntegers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

var stack = new Stack<int>(inputIntegers);

string input = "";

while ((input = Console.ReadLine().ToLower()) != "end")
{
    string[] tokens = input
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string command = tokens[0];
    
    if (command == "add")
    {
        int firstNumber = int.Parse(tokens[1]);
        stack.Push(firstNumber);
        int secondNumebr = int.Parse(tokens[2]);
        stack.Push(secondNumebr);
    }
    else
    {
        int givenNumber = int.Parse(tokens[1]);

        if (givenNumber > stack.Count)
        {
            continue;
        }
        else
        {
            while (givenNumber > 0 && stack.Count > 0)
            {
                stack.Pop();
                givenNumber--;
            }
        }
    }
}
int sum = 0;

foreach (var number in stack)
{
    sum += number;
}

Console.WriteLine($"Sum: {sum}");