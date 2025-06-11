
int startRange = int.Parse(Console.ReadLine());
int endRange  = int.Parse(Console.ReadLine());

for (int currNum = startRange; currNum <= endRange; currNum++)
{
    int counter = 0;
    bool isPrime = true;
    for (int j = 1; j <= currNum; j++) // serch prime number
    {
        if (currNum % j == 0)
        {
            counter++;

        }
    }
     if (counter > 2)
    {
        isPrime = false;
    }

     if (isPrime)
           Console.Write(currNum + " ");
}