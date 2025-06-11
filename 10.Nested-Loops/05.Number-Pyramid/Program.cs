
int n = int.Parse(Console.ReadLine());

int counter = 0;

for (int rows = 1;  rows <= n;  rows++)
{
	for (int col = 1; col <= rows; col++)
	{
		counter++;
		Console.Write($"{counter} ");
		if (counter == n)
			break;
	}
	if (counter == n)
		break;
	Console.WriteLine();
}