
List<int> train = Console.ReadLine()
                         .Split(" ")
                         .Select(int.Parse)
                         .ToList();

int wagonCapacity = int.Parse(Console.ReadLine());

string command = Console.ReadLine();

while (command != "end")
{
    string[] cmdArg = command.Split(" ");

    if (cmdArg[0] == "Add")
    {
        int passangersToAdd = int.Parse(cmdArg[1]);

        train.Add(passangersToAdd);
    }
    else
    {
        int passangersToAdd = int.Parse(cmdArg[0]);

        for (int i = 0; i < train.Count; i++)
        {
            int currentPassangers = train[i];

            if (wagonCapacity - currentPassangers >= passangersToAdd)
            {
                train[i] = currentPassangers + passangersToAdd;
                break;
            }
        }
        Console.WriteLine(command);
    }
}

Console.WriteLine(string.Join(" ", train));