// Input

int hour = int.Parse(Console.ReadLine());
string day = Console.ReadLine();

// Output

if (hour >= 10 && hour <= 18)
{
    if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday")
    {
        Console.WriteLine("open");
    }
    else
    {
        Console.WriteLine("closed");
    }
}
else
{
    Console.WriteLine("closed");
}
