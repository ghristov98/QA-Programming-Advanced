﻿// Input

char letter = char.Parse(Console.ReadLine());

// Output

if (letter == 'A' || letter == 'a' || letter == 'E' || letter == 'e'
    || letter == 'I' || letter == 'i' || letter == 'O' || letter == 'o'
    || letter == 'U' || letter == 'u')
{
    Console.WriteLine("Vowel");
}
else
{
    Console.WriteLine("Consonant");
}