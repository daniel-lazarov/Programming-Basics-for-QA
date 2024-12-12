int nylon = int.Parse(Console.ReadLine());
int paint = int.Parse(Console.ReadLine());
int thinner = int.Parse(Console.ReadLine());
int workHours = int.Parse(Console.ReadLine());

double nylonAmount = (nylon + 2) * 1.5;
double paintAmount = (paint + (paint * 0.1)) * 14.5;
int thinnerAmount = thinner * 5;

double materialsTotal = nylonAmount + paintAmount + thinnerAmount + 0.4;

double workAmount = (materialsTotal * 0.3) * workHours;

double totalAmount = materialsTotal + workAmount;

Console.WriteLine($"{totalAmount}");