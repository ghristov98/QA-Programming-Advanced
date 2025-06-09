// Input

string type = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int seats = int.Parse(Console.ReadLine());

double price1 = 7.50;
double price2 = 12.00;
double price3 = 5.00;
// Output

if (type == "Normal")
{
    int allSeatsInCinema1 = rows * seats;
    double totalPriceforNormall = allSeatsInCinema1 * price1;
    Console.WriteLine($"{totalPriceforNormall:F2}");
}
else if (type == "Premiere")
{
    int allSeatsInCinema2 = rows * seats;
    double totalPriceforPremiere = allSeatsInCinema2 * price2;
    Console.WriteLine($"{totalPriceforPremiere:F2}");
}
else if (type == "Discount")
{
    int allSeatsInCinema3 = rows * seats;
    double totalPriceforDiscount = allSeatsInCinema3 * price3;
    Console.WriteLine($"{totalPriceforDiscount:F2}");
}
