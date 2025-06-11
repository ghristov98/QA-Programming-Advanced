
int num = int.Parse(Console.ReadLine());   

double sum = 0;
for (int i = 1; i <= num; i++)
{
    double currentNumber = double.Parse(Console.ReadLine());

    sum += currentNumber;

}

Console.WriteLine(sum);