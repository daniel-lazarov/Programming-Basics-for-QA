double tomatoPrice = double.Parse(Console.ReadLine());
double tomatoQty = double.Parse(Console.ReadLine());
double cucumberPrice = double.Parse(Console.ReadLine());
double cucumberQty = double.Parse(Console.ReadLine());

double tomatoCost = tomatoPrice * tomatoQty;
double cucumberCost = cucumberPrice * cucumberQty;

double totalCost = tomatoCost + cucumberCost;

Console.WriteLine($"{totalCost:F2}");