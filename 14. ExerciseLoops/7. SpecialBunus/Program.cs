int stopNumber = int.Parse(Console.ReadLine());

int previousNumber = 0;
int currentNumber = 0;

while (currentNumber != stopNumber)
{
    previousNumber = currentNumber;
    currentNumber = int.Parse(Console.ReadLine());

}

double bonus = previousNumber * 0.2;
double result = previousNumber + bonus;

Console.WriteLine(result);