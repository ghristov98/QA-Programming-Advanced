//• Chicken menu – 10.35 lv.

//• Menu with fish – 12.40 lv.

//• Vegetarian menu – 8.15 lv. 


//Input
int chickenMenu = int.Parse(Console.ReadLine());
int fishMenu = int.Parse(Console.ReadLine());
int vegetarianMenu = int.Parse(Console.ReadLine());

//Calculations
double priceChickenMenu = chickenMenu * 10.35;
double priceFishMenu = fishMenu * 12.40;
double priceVegetarianMenu = vegetarianMenu * 8.15;
double totalPriceMenus = priceChickenMenu + priceFishMenu + priceVegetarianMenu;
double priceDessert = totalPriceMenus * 0.2;
double priceDelivery = 2.50;//conditional
double totalPrice = totalPriceMenus + priceDessert + priceDelivery;

//Output

Console.WriteLine(totalPrice);
