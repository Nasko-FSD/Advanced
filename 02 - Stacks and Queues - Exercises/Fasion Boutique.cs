int[] clothes = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

clothes.Reverse();

Stack<int> stack = new Stack<int>(clothes);

int rackVolume = int.Parse(Console.ReadLine());

int totalRacks = 1;
int sumClothes = 0;

while (stack.Any())
{
    int currentCloth = stack.Peek();

    if (sumClothes + currentCloth <= rackVolume)
    {
        sumClothes += stack.Pop();
    }
    else
    {
        totalRacks++;
        sumClothes = 0;
    }

}

Console.WriteLine(totalRacks);