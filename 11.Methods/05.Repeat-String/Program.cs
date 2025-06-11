internal class Program
{
    private static void Main(string[] args)
    {
        string text = Console.ReadLine();
        int num = int.Parse(Console.ReadLine());

        ReturningText(text, num);
    }

    private static void ReturningText(string text, int num)
    {
        for (int i = 1; i <= num; i++)
        {
            Console.Write(text);
        }

    }

}
