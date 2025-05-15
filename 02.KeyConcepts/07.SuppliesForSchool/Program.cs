
// Prices

double penPrice = 5.80;
double markerPrice = 7.20;
double boardCleaner = 1.20;

// Input

int penQuantity = int.Parse(Console.ReadLine());
int markerQuantity = int.Parse(Console.ReadLine());
int boardCleanerQuantity = int.Parse(Console.ReadLine());
int discountPercentage = int.Parse(Console.ReadLine());

// Calculations

double penTotal = penQuantity * penPrice;
double markerTotal = markerQuantity * markerPrice;
double boardCleanerTotal = boardCleanerQuantity * boardCleaner;
double totalPrice = penTotal + markerTotal + boardCleanerTotal;
double discount = totalPrice * (discountPercentage / 100.0);
double totalPriceWithDiscount = totalPrice - discount;

// Output

Console.WriteLine($"{totalPriceWithDiscount:F3}");