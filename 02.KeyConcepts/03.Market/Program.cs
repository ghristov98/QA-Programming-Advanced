// Input

double tomatoesPrice = double.Parse(Console.ReadLine());
double tomatoesQuantity = double.Parse(Console.ReadLine());
double cucumberPrice = double.Parse(Console.ReadLine());
double cucumberQuantity = double.Parse(Console.ReadLine());

// Calculations

double tomatoesTotal = tomatoesPrice * tomatoesQuantity;   
double cucumberTotal = cucumberPrice * cucumberQuantity;
double totalPrice = tomatoesTotal + cucumberTotal;

// Output

Console.WriteLine($"{totalPrice:F2}"); 