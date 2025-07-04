
int[] inputArray = Console.ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .ToArray();

for (int i = 0; i < inputArray.Length; i++)
{
    int currElement = inputArray[i];
    bool isBigger = true;
    //започвам от следващия десен елемент
    for (int j = i + 1; j < inputArray.Length; j++)
    {
        int nextRightElement = inputArray[j];

        if (currElement <= nextRightElement)
        {
            isBigger = false;
            break;
        }
    }
   if (isBigger)
    {
        Console.Write(currElement + " ");
    }
}