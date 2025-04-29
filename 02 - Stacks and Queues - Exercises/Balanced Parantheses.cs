string input = Console.ReadLine();

Stack<char> stackParentheses = new Stack<char>();
bool isSuccess = true;

for (int i = 0; i < input.Length; i++)
{
    char currentChar = input[i];

    if (currentChar == '{' || currentChar == '[' || currentChar == '(')
    {
        stackParentheses.Push(currentChar);
        continue;
    }

    if (stackParentheses.Count == 0)
    {
        isSuccess = false;
        break;
    }

    if (currentChar == '}' && stackParentheses.Peek() == '{'
        || currentChar == ']' && stackParentheses.Peek() == '['
        || currentChar == ')' && stackParentheses.Peek() == '(')
    {
        stackParentheses.Pop();
    }

    else
    {
        isSuccess = false;
        break;
    }
}

if (isSuccess == true)
{
    Console.WriteLine("YES");
}

else
{
    Console.WriteLine("NO");
}