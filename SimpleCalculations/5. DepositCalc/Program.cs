double depositAmount = double.Parse(Console.ReadLine());
int periodInMonths = int.Parse(Console.ReadLine());
double interestRate = double.Parse(Console.ReadLine());

double totalInterest = depositAmount * interestRate / 100;
double monthlyInterest = totalInterest / 12;
double amount = depositAmount + monthlyInterest * periodInMonths;

//double amount = depositAmount + (periodInMonths * ((depositAmount * interestRate) / 12));

Console.WriteLine($"{amount:F2}");
