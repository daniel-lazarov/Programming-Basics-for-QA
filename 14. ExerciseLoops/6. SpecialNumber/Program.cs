int n = int.Parse(Console.ReadLine());

int tempNumber = n;
bool isSpecialNumber = true;

while (tempNumber > 0)
{
    int lastDigit = tempNumber % 10;
    tempNumber /= 10;

    if (n % lastDigit != 0)
    {
        isSpecialNumber = false;
        break;
    }
}

if(isSpecialNumber)
{
    Console.WriteLine($"{n} is special");
}
else
{
    Console.WriteLine($"{n} is not special");
}