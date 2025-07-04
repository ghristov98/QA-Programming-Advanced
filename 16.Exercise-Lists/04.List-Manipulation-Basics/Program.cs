List<int> numbers = Console.ReadLine()
                           .Split(" ")
                           .Select(int.Parse)
                           .ToList();

string input = Console.ReadLine();

while (input != "end")
{
    string[] cmdArg = input.Split(" ");
    string command = cmdArg[0]; 

    if (command == "Add")
    {
        int number = int.Parse(cmdArg[1]);
        numbers.Add(number);
    }
    else if (command == "Remove")
    {
        int number = int.Parse(cmdArg[1]);
        numbers.Remove(number);
    }
    else if (command == "RemoveAt")
    {
        int index = int.Parse(cmdArg[1]);
        numbers.RemoveAt(index);
    }
    else if (command == "Insert")
    {
        int number = int.Parse(cmdArg[1]);
        int index = int.Parse(cmdArg[2]);
        numbers.Insert(index, number);
    }
    input = Console.ReadLine();
}
Console.WriteLine(string.Join(" ", numbers));