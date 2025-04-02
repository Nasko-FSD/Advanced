var input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

var result = new Stack<string>(input.Reverse());

while (result.Count > 1)
{
    var firstNumber = int.Parse(result.Pop());
    var operation = result.Pop();
    var secondNumber = int.Parse(result.Pop());

    var tempResult = operation switch 
    {
        "+" => (firstNumber + secondNumber),
        "-" => (firstNumber - secondNumber),
        _ => 0
    };
    result.Push(tempResult.ToString());
}

Console.WriteLine(result.Pop());