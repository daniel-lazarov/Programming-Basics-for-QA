﻿double number1 = double.Parse(Console.ReadLine());
double number2 = double.Parse(Console.ReadLine());
string mathOperator = Console.ReadLine();

double result = 0;

if (mathOperator == "+")
{
    result = number1 + number2;
}
else if (mathOperator == "-")
{
    result = number1 - number2;
}
else if (mathOperator == "*")
{
    result = number1 * number2;
}
else if (mathOperator == "/")
{
    result = number1 / number2;
}
else
{
    Console.WriteLine("invalid opetator");
}

Console.WriteLine($"{number1} {mathOperator} {number2} = {result:F2}");