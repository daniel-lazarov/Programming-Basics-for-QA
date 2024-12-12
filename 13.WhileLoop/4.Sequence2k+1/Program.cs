int maxNumber = int.Parse(Console.ReadLine());
int firstNumber = 1;

while (firstNumber <= maxNumber)
{
    Console.WriteLine(firstNumber);
    firstNumber = 2 * firstNumber + 1;
}

Console.WriteLine(firstNumber);