int[] firstArray = Console.ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .ToArray();
int[] secondArray = Console.ReadLine()
                           .Split()
                          .Select(int.Parse)
                          .ToArray();

bool isIdentical = true;

for (int x = 0; x < firstArray.Length; x++)
{
        if (firstArray[x] != secondArray[x])
        {
            isIdentical = false;
            break;
        }
}
if (isIdentical)
{
    Console.WriteLine("Arrays are identical.");
}
else
{
    Console.WriteLine("Arrays are not identical.");
}
