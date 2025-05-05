int greenLight = int.Parse(Console.ReadLine());
int freeWindow = int.Parse(Console.ReadLine());

Queue<string> cars = new Queue<string>();
int carsPassed = 0;
string input = Console.ReadLine();
int collisionIndex = 0;
bool isSuccess = true;
string currentCar = "";

while (input != "END")
{
    if (input == "green")
    {
        int timeLeft = greenLight;

        while (cars.Any() && timeLeft > 0)
        {
            currentCar = cars.Peek();
            int carsLength = currentCar.Length;

            timeLeft -= carsLength;

            if (timeLeft >= 0)
            {
                carsPassed++;
                cars.Dequeue();
            }
            else
            {
                int leftToPass = Math.Abs(timeLeft);
                if (leftToPass <= freeWindow)
                {
                    carsPassed++;
                    cars.Dequeue();
                    break;
                }
                else
                {
                    collisionIndex = carsLength - (leftToPass - freeWindow);
                    isSuccess = false;
                    break;
                }
            }
        }

        if (!isSuccess)
        {
            break;
        }
    }
    else
    {
        cars.Enqueue(input);
    }

    input = Console.ReadLine();
}

if (isSuccess)
{
    Console.WriteLine("Everyone is safe.");
    Console.Write($"{carsPassed} total cars passed the crossroads.");
}
else
{
    char atChar = currentCar[collisionIndex];
    Console.WriteLine("A crash happened!");
    Console.Write($"{currentCar} was hit at {atChar}.");
}