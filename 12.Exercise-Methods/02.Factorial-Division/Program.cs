
int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());
//изчисляваме факториел на първото число
int factFirstNum = CalculateFactorial(firstNum);

//изчисляваме факториел на второто число
int factSecondNum = CalculateFactorial(secondNum);

//разделяме факториел на първото число на факториел на второто число
int result = factFirstNum / factSecondNum;

Console.WriteLine(result);
static int CalculateFactorial(int number)
{
    int fact = 1;//факториела на числото
	for (int i = 1; i <= number; i++)
	{
		//i -> съхранявам всяко едно число от 1 до моето
		fact = fact * i;
	}
	return fact;
}
