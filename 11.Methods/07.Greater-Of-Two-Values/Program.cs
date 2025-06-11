



internal class Program
{
    private static void Main(string[] args)
    {
        string type = Console.ReadLine();
        string firstValue  = Console.ReadLine();
        string secondValue  = Console.ReadLine();

        CompateTwoValues(type, firstValue, secondValue);
    }

    private static string CompateTwoValues(string type, string? firstValue, string? secondValue)
    {
        if (type == "int")
        {
            int a = int.Parse(firstValue);
            int b = int.Parse(secondValue);

            Console.WriteLine(CompateTwoIntegers(a, b));
        }
        else if (type == "char")
        {
            char a = char.Parse(firstValue);
            char b = char.Parse(secondValue);

            Console.WriteLine(CompareTwoChars(a, b));
        }
        else if (type == "string")
        {
         Console.WriteLine(CompareTwoStrings(firstValue, secondValue));
        }

        return "";
    }

    private static string CompareTwoStrings(string? firstString, string? secondString)
    {
        int result = firstString.CompareTo(secondString);

        if (result > 1)
        {
            return firstString;
        }
        else
        {
            return secondString;
        }
    }

    private static char CompareTwoChars(char a, char b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    private static int CompateTwoIntegers(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}