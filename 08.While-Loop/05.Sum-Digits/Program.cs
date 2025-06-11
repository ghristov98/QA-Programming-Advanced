
int num = int.Parse(Console.ReadLine());

int sum = 0;

while (num > 0)
{
    int lastNum = num % 10;
    sum += lastNum;
    num /= 10;

}

Console.WriteLine(sum);