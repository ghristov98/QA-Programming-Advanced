
int[] inputArray = Console.ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .ToArray();

int rotaitons = int.Parse(Console.ReadLine());

for (int i = 0; i < rotaitons; i++)
{
    // запазвам си първия елемент
    int firstElement = inputArray[0];

    // местя всички елементи от индекс 1, една позиция на ляво  
    for (int j = 1; j < inputArray.Length; j++)
    {
        inputArray[j - 1] = inputArray[j];
    }
    //местя първият елемент като последен
    inputArray[inputArray.Length - 1] = firstElement;
}
Console.WriteLine(string.Join(" ", inputArray));