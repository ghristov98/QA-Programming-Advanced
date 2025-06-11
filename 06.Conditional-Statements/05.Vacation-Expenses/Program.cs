// Input

string season = Console.ReadLine();
string accom = Console.ReadLine();
int daysLeft = int.Parse(Console.ReadLine());

double pricePerNight = 0;
// Output

switch (season)
{
    case "Spring":
        if (accom == "Hotel") 
        {
            // 30 - 20% = 24
            pricePerNight = 24;
        }
        else if (accom == "Camping") 
        {
            // 10 - 20% = 8
            pricePerNight = 8;
        }
    break;
    case "Summer":
        if (accom == "Hotel")
        {
            // 50 - 0% = 50
            pricePerNight = 50;
        }
        else if (accom == "Camping")
        {
            // 30 - 0% = 30
            pricePerNight = 30;
        }
        break;
    case "Autumn":
        if (accom == "Hotel")
        {
            // 20 - 30% = 14
            pricePerNight = 14;
        }
        else if (accom == "Camping")
        {
            // 15 - 30% = 10.5
            pricePerNight = 10.50;
        }
        break;
    case "Winter":
        if (accom == "Hotel")
        {
            // 40 - 10% = 36
            pricePerNight = 36;
        }
        else if (accom == "Camping")
        {
            // 10 - 10% = 9
            pricePerNight = 9;
        }
        break;
}

double totalSum = daysLeft * pricePerNight;
Console.WriteLine($"{totalSum:F2}");