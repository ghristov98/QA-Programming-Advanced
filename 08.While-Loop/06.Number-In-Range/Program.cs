
int num = int.Parse(Console.ReadLine());

//345
while (num < 1 || num > 100)
{
    num = int.Parse(Console.ReadLine());
}
Console.WriteLine(num);