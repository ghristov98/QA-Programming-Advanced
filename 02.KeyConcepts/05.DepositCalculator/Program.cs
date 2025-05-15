// Input
double depositAmount = double.Parse(Console.ReadLine());
int months = int.Parse(Console.ReadLine());
double yearinterestRate = double.Parse(Console.ReadLine());

// Calculations

double yearIncome = depositAmount * (yearinterestRate / 100);
double monthIncome = yearIncome / 12;

double totalIncome = depositAmount + (months * monthIncome);

// Output

Console.WriteLine(totalIncome);