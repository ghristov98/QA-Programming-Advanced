
int num = Math.Abs(int.Parse(Console.ReadLine()));

static int GetSomeOfEvenDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        int lastDigit = num % 10;
        if (lastDigit % 2 == 0)
        {
            sum += lastDigit;
        }
        num /= 10;
    }
    return sum;
}

static int GetSumOfOddDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        int lastDigit = num % 10;
        if (lastDigit % 2 != 0)
        {
            sum += lastDigit;
        }
        num /= 10;
    }
    return sum; 
}
static int GetMultiplyOfEvenAndOdds(int num)
{
    return GetSomeOfEvenDigits(num) * GetSumOfOddDigits(num);
}

Console.WriteLine(GetMultiplyOfEvenAndOdds(num));