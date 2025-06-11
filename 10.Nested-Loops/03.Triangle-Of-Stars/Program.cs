
int c = int.Parse(Console.ReadLine());

for (int a = 1; a <= c; a++)
{
    for (int b = 1; b <= a; b++)
    {
        Console.Write('*');
    }
    Console.WriteLine();
}