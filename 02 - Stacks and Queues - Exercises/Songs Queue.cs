string[] inputSongs = Console.ReadLine()
    .Split(", ")
    .ToArray();

Queue<string> queue = new Queue<string>(inputSongs);


while (queue.Any())
{
    string[] enteredCommand = Console.ReadLine()
        .Split(" ")
        .ToArray();

    string command = enteredCommand[0];

    switch (command)
    {
        case "Play":
            queue.Dequeue();
            break;

        case "Add":
            string songName = string.Join(" ", enteredCommand.Skip(1));
            if (queue.Contains(songName) == false)
            {
                queue.Enqueue(songName);
            }
            else
            {
                Console.WriteLine($"{songName} is already contained!");
            }
            break;

        case "Show":
            {

                Console.WriteLine(string.Join(", ", queue));
                break;
            }
    }

}
Console.WriteLine("No more songs!");