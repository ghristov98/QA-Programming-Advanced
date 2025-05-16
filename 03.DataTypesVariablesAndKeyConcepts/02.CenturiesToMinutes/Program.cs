
// Input

int centuries = int.Parse(Console.ReadLine());
int years = centuries * 100; // 1 centurie = 100 years
int days = (int)(years * 365.2422); // 1 year = 365.2422 days
int hours = days * 24;
int minutes = hours * 60;

// Output

Console.WriteLine($"{ centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");