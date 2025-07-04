List<int> numbers = Console.ReadLine() 
                    .Split()           
                    .Select(int.Parse) 
                    .ToList();         

string command = Console.ReadLine();


while (command != "end")
{
   
    string[] commandParts = command.Split();
    string commandName = commandParts[0]; 

    if (commandName == "Delete")
    {
        int numberToBeRemoved = int.Parse(commandParts[1]); 
        numbers.RemoveAll(number => number == numberToBeRemoved);
    }
    else if (commandName == "Insert")
    {
        int numberToInsert = int.Parse(commandParts[1]); 
        int positionToInsert = int.Parse(commandParts[2]); 
        numbers.Insert(positionToInsert, numberToInsert);
    }

    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));