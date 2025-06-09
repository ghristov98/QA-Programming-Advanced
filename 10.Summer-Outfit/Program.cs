﻿// Input

int temperature = int.Parse(Console.ReadLine());
string timeOfDay = Console.ReadLine();
string outfit = "";
string shoes = "";

// Output

if (temperature >= 10 && temperature <= 18)
{
    if (timeOfDay == "Morning")
    {
        outfit = "Sweatshirt";
        shoes = "Sneakers";
    }
    else if (timeOfDay == "Afternoon" || timeOfDay == "Evening")
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
}
else if (temperature >= 18 && temperature <= 24)
{
    if (timeOfDay == "Morning" || timeOfDay == "Evening")
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
    else if (timeOfDay == "Afternoon")
    {
        outfit = "T-Shirt";
        shoes = "Sandals";
    }
}
else if (temperature >= 25 && temperature <= 42)
{
    if (timeOfDay == "Morning")
    {
        outfit = "T-Shirt";
        shoes = "Sandals";
    }
    else if (timeOfDay == "Afternoon")
    {
        outfit = "Swim Suit";
        shoes = "Barefoot";
    }
    else if (timeOfDay == "Evening")
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
}

Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");