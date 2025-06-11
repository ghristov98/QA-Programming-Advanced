
internal class Program
{
    private static void Main(string[] args)
    {
         int width = int.Parse(Console.ReadLine());
         int length = int.Parse(Console.ReadLine());


        int area = CalculateRengtangeArea(width, length);
        Console.WriteLine(area);
    }

    private static int CalculateRengtangeArea(int width, int length)
    {
        return width * length;
    }
}