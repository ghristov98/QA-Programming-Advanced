


internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        PrintFirstPartTriangle(n);
        PrintSecondPartTriangle(n);
    }

    private static void PrintFirstPartTriangle(int side)
    {
        for (int row = 1; row <= side; row++) // how many rows to print
        {
            for (int i = 1; i <= row; i++) // how many numbers in a row to print
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }

    private static void PrintSecondPartTriangle(int side)
    {
        for (int row = side - 1; row >= 1; row--) // how many rows to print 
        {
            for (int i = 1; i <= row; i++) // how many number in a row
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}