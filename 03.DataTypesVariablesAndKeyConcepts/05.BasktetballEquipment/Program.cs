// Input
int trainingFee = int.Parse(Console.ReadLine());

//Calculations

int pricePerYear = trainingFee;
int priceSneakers = (int)(pricePerYear - (pricePerYear * 0.4));
double priceUniform = priceSneakers - (priceSneakers * 0.2);
double priceBall = priceUniform * 0.25;
double priceAccessories = priceBall * 0.2;
double priceTotal = pricePerYear + priceSneakers + priceUniform + priceBall + priceAccessories;

//Output

Console.WriteLine(priceTotal);