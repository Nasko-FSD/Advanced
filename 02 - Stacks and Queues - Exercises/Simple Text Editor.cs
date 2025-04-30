int totalCount = int.Parse(Console.ReadLine());

Stack<string> stack = new Stack<string>();

string text = "";

for (int i = 0; i < totalCount; i++)
{
    string[] input = Console.ReadLine()
        .Split();

    int command = int.Parse(input[0]);

    switch (command)
    {
        case 1:
            text += input[1];
            stack.Push(text);
            break;
        case 2:
            int charsToErase = int.Parse(input[1]);
            text = text.Substring(0, text.Length - charsToErase);
            stack.Push(text);
            break;
        case 3:
            int index = int.Parse(input[1]);
            Console.WriteLine(text[index - 1]);
            break;
        case 4:
            stack.Pop();
            if (stack.Any())
            {
                text = stack.Peek();
            }
            else
            {
                text = "";
            }
            break;
    }
}