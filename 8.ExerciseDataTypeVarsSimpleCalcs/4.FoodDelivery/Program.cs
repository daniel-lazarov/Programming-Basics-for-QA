double chickenMenuPriceLv = 10.35;
double fishMenuPriceLv = 12.4;
double veggieMenuPriceLv = 8.15;
double deliveryPriceLv = 2.5;

int numberChickenMenus = int.Parse(Console.ReadLine());
int numberFishMenus = int.Parse(Console.ReadLine());
int numberVeggieMenus = int.Parse(Console.ReadLine());

double chickenMenusTotal = numberChickenMenus * chickenMenuPriceLv;
double fishMenusTotal = numberFishMenus * fishMenuPriceLv;
double veggieMenustotal = numberVeggieMenus * veggieMenuPriceLv;

double menuTotal = chickenMenusTotal + fishMenusTotal + veggieMenustotal;

double dessertTotal = menuTotal * 0.2;

double grandTotal = menuTotal + dessertTotal + deliveryPriceLv;

Console.WriteLine(grandTotal);