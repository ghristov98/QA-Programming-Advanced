// Input

double n1 = double.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine());
string mathOpr = Console.ReadLine();

// Output

if (mathOpr == "+")
{
    double resultSum = n1 + n2;
    Console.WriteLine($"{n1} {mathOpr} {n2} = {resultSum:F2}");
}
else if (mathOpr == "-")
{
    double resultSub = n1 - n2;
    Console.WriteLine($"{n1} {mathOpr} {n2} = {resultSub:F2}");
}
else if (mathOpr == "*")
{
    double resultMulti = n1 * n2;
    Console.WriteLine($"{n1} {mathOpr} {n2} = {resultMulti:F2}");
}
else if (mathOpr == "/")
{
    double resultDevi = n1 / n2;
    Console.WriteLine($"{n1} {mathOpr} {n2} = {resultDevi:F2}");
}
