﻿// Input

int points = int.Parse(Console.ReadLine());

// Output

if (points >= 0 && points <= 3)
{
    Console.WriteLine(points + 5);
}
else if (points >= 4 && points <= 6)
{
    Console.WriteLine(points + 15);
}
else if (points >= 7 && points <= 9)
{
    Console.WriteLine(points + 20);
}
