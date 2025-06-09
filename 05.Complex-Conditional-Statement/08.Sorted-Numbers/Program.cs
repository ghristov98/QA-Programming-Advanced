// Input

int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 =  int.Parse(Console.ReadLine());

// Output

if (number1 < number2 && number2 < number3)
{
    Console.WriteLine("Ascending");
}
else if (number3 < number2 && number2 < number1)
{
    Console.WriteLine("Descending");
}
else
{
    Console.WriteLine("Not sorted");
}
