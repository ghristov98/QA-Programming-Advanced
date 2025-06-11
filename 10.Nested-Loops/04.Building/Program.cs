
int countFloors = int.Parse(Console.ReadLine());
int countEstates = int.Parse(Console.ReadLine());

for (int floors = countFloors; floors >= 1; floors--)
{
	for (int apts = 0; apts < countEstates; apts++)
	{
		if (countFloors == floors)
		{
            Console.Write($"L{floors}{apts} ");
		}
		else if (floors % 2 == 0)
		{
			Console.Write($"O{floors}{apts} ");
		}
		else
		{
            Console.Write($"A{floors}{apts} ");
		}
	}
    Console.WriteLine();
}