int countProducts = int.Parse(Console.ReadLine());
List<string> products = new List<string>(); 


for (int product = 1; product <= countProducts; product++)
{
    
    string productName = Console.ReadLine();
    products.Add(productName);
}



products.Sort(); 


int number = 1; 
foreach (string product in products)
{
    Console.WriteLine(number + "." + product);
    number++;
}
