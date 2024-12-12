int pens = int.Parse(Console.ReadLine());
int markers = int.Parse(Console.ReadLine());
int cleaner = int.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());

double totalAmount = pens * 5.8 + markers * 7.2 + cleaner * 1.2;
double discountAmount = totalAmount * discount / 100;
double finalAmount = totalAmount - discountAmount;

Console.WriteLine(finalAmount);