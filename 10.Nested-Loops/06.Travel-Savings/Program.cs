
string destination = Console.ReadLine();

while (destination != "End")
{
    double neededSum = double.Parse(Console.ReadLine());
    double savedSum = 0;

    while (savedSum < neededSum)
    {
        double currentSum = double.Parse(Console.ReadLine());
        savedSum += currentSum;
        Console.WriteLine($"Collected: {savedSum:F2}");
    }

    Console.WriteLine($"Going to {destination}!");

    destination = Console.ReadLine();

}
