int totalCmmands = int.Parse(Console.ReadLine());
Stack<string> stack = new Stack<string>();
stack.Push("");

for (int i = 0; i < totalCmmands; i++)
{
    string[] input = Console.ReadLine()
        .Split();

    int command = int.Parse(input[0]);

    switch (command)
    {
        case 1:
            string toInput = input[1];
            stack.Push(stack.Peek() + toInput);
            break;

        case 2:
            int toErase = int.Parse(input[1]);
            string lastInput = stack.Peek();
            stack.Push(lastInput.Substring(0, lastInput.Length - toErase));
            break;

        case 3:
            int atIndex = int.Parse(input[1]);
            Console.WriteLine(stack.Peek()[atIndex - 1]);
            break;

        case 4:
            stack.Pop();
            break;
    }
}