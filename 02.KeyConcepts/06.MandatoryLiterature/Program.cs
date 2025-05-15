// Input
int pagesNumber = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());   
int days = int.Parse(Console.ReadLine());

// Calculations

int totalTime = pagesNumber / pagesPerHour;

int hoursPerDay = totalTime / days;

// Output

Console.WriteLine(hoursPerDay);