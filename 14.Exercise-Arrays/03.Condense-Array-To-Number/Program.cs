
int[] firstArray = Console.ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .ToArray();

int counter = firstArray.Length;

if (firstArray.Length == 1 )
    Console.WriteLine(firstArray[0]);

while (counter > 1)
{
    int[] condensedArray = new int[counter - 1];

    for (int i = 0; i < counter - 1; i++)
    {
        condensedArray[i] = firstArray[i] + firstArray[i + 1];
    }

    counter--;

    firstArray = condensedArray;

    if (counter == 1)
    {
        Console.WriteLine(condensedArray[0]);
      
    }
}
