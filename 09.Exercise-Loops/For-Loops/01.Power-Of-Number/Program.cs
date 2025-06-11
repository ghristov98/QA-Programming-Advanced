int num = int.Parse(Console.ReadLine());
int pow = int.Parse(Console.ReadLine());
int result = 1;

for (int count = 1; count <= pow; count++)
{
    result = result * num;
}
Console.WriteLine(result);