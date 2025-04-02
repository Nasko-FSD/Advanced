var input = Console.ReadLine();

var stack = new Stack<char>(input);

while (stack.Any())
{
    Console.Write(stack.Pop());
}