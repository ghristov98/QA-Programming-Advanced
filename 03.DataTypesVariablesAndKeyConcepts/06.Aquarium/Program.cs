
//Input

int lenght = int.Parse(Console.ReadLine());// lenght in cm
int width = int.Parse(Console.ReadLine());// width in cm
int height = int.Parse(Console.ReadLine());// height in cm
double percentage = double.Parse(Console.ReadLine());

//Calculations

double volumeAquarium = lenght * width * height; //cm^3
double volumeLiters = volumeAquarium / 1000; //liters
double occupiedSpace = percentage / 100;
double requiredLiters = volumeLiters * ( 1 - occupiedSpace );//liters

//Output

Console.WriteLine($"{requiredLiters:F2}");