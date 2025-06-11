// Input

double firstNumber = double.Parse(Console.ReadLine());
double secondNumber  = double.Parse(Console.ReadLine());
double thirdNumber = double.Parse(Console.ReadLine());

int countNegativeNumbers = 0;

// Output

if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
{
    Console.WriteLine("zero");
}
else
{
    if (firstNumber < 0)
    {
        countNegativeNumbers++;
    }
    if (secondNumber < 0)
    {
        countNegativeNumbers++;
    }
    if (thirdNumber < 0)
    {
        countNegativeNumbers++;
    }
    if (countNegativeNumbers % 2 == 0)
    {
        Console.WriteLine("positive");
    }
    else
    {
        Console.WriteLine("negative");
    }
}
