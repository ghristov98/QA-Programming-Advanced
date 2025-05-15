// Input

double firstNumber = double.Parse(Console.ReadLine());

double secondNumber = double.Parse(Console.ReadLine());

// Calculations

// Addition

double sum = firstNumber + secondNumber;

// Subtraction

double subs = firstNumber - secondNumber;

// Multiplication

double mult = firstNumber * secondNumber;

// Division

double div = firstNumber / secondNumber;

// Output

Console.WriteLine($"{firstNumber:F2} + {secondNumber:F2} = {sum:F2}");
Console.WriteLine($"{firstNumber:F2} - {secondNumber:F2} = {subs:F2}");
Console.WriteLine($"{firstNumber:F2} * {secondNumber:F2} = {mult:F2}");
Console.WriteLine($"{firstNumber:F2} / {secondNumber:F2} = {div:F2}");

