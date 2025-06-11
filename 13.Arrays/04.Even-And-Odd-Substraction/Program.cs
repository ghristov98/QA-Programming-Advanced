
int[] numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int evenSum = 0;
int oddSum = 0;

foreach (int item in numbers)
{
    if (item % 2 == 0) // проверяваме дали стойността е четна
    {
        evenSum += item;
    }
    else               // проверяваме дали стойността е нечетна
    {
        oddSum += item;
    }
}

Console.WriteLine(evenSum - oddSum);