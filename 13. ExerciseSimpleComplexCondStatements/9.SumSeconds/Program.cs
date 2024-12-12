int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

int sumMinutes = num1 + num2 + num3;
int minutes = sumMinutes / 60;
int seconds = sumMinutes % 60;

Console.WriteLine($"{minutes}:{seconds:D2}");