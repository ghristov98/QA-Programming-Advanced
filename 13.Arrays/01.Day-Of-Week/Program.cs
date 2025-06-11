
int index = int.Parse(Console.ReadLine());

string[] daysOfWeek = new string[] 
{ 
    "Monday",
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday",
    "Sunday"
};

if (index < 1 || index > 7)
{
    Console.WriteLine("Invalid day!");
}
else
{
    Console.WriteLine(daysOfWeek[index-1]);
}

