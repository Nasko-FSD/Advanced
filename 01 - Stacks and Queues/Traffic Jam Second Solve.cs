int passingCars = int.Parse(Console.ReadLine());

Queue<string> cars = new Queue<string>();

int totalCarsPassed = 0;

while (true)
{
    string command = Console.ReadLine();

    if (command == "green")
    {
        for (int i = 0; i < passingCars; i++)
        {
            if (cars.Any())
            {
                var currentCar = cars.Dequeue();
                Console.WriteLine($"{currentCar} passed!");
                totalCarsPassed++;
            }
        }
    }
    else if (command == "end")
    {
        break;
    }
    else 
    {
        cars.Enqueue(command);
    }
}
Console.WriteLine($"{totalCarsPassed} cars passed the crossroads.");