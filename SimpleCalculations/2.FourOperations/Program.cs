double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());

double sumResult = firstNumber + secondNumber;
double substrResult = firstNumber - secondNumber;
double multiplyResult = firstNumber * secondNumber;
double divisionResult = firstNumber / secondNumber;

Console.WriteLine($"{firstNumber:F2} + {secondNumber:F2} = {sumResult:F2}");
Console.WriteLine($"{firstNumber:F2} - {secondNumber:F2} = {substrResult:F2}");
Console.WriteLine($"{firstNumber:F2} * {secondNumber:F2} = {multiplyResult:F2}");
Console.WriteLine($"{firstNumber:F2} / {secondNumber:F2} = {divisionResult:F2}");