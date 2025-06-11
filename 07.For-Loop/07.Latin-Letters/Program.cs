
char firstLetter = char.Parse(Console.ReadLine());
char secondLetter = char.Parse(Console.ReadLine());

for (int i = firstLetter; i <= secondLetter; i++)
{
    Console.Write($"{(char)i} ");
}
