// Input

int timeOne = int.Parse(Console.ReadLine());
int timeTwo = int.Parse(Console.ReadLine());
int timeThree = int.Parse(Console.ReadLine());

int totalTimeSeconds = timeOne + timeTwo + timeThree;

int minutes = totalTimeSeconds / 60;
int seconds = totalTimeSeconds % 60;

Console.WriteLine($"{minutes}:{seconds:D2}");