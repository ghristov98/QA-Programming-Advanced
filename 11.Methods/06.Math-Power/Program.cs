using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());

        double sum = Math.Pow(num, power);
        Console.WriteLine(sum);
        
    }
    
}