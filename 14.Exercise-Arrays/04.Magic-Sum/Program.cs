int[] inputArray = Console.ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .ToArray();

int controlNum = int.Parse(Console.ReadLine());

for (int i = 0; i < inputArray.Length - 1; i++) // минавам през всички елементи без последния
{
    int leftElement = inputArray[i];

    for (int j = i + 1; j < inputArray.Length; j++) // минавам прес всички елементи надясно от текущия
    {
        int rightElement = inputArray[j];

        int sum = leftElement + rightElement;

        if (sum == controlNum)
        {
          Console.WriteLine($"{leftElement} {rightElement}");
            break;
        }
    }

    
    
}