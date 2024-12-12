int n = int.Parse(Console.ReadLine());

int numsDivideBy2Mod0 = 0;
int numsDivideBy3Mod0 = 0;
int numsDivideBy4Mod0 = 0;

for (int i = 0; i < n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());

    if (currentNumber % 2 == 0)
    {
        numsDivideBy2Mod0++;
    }

    if (currentNumber % 3 == 0)
    {
        numsDivideBy3Mod0++;
    }

    if (currentNumber % 4 == 0)
    {
        numsDivideBy4Mod0++;
    }
}

double numsDividedBy2Mod0Percentage = (double)numsDivideBy2Mod0 / n * 100;
double numsDividedBy3Mod0Percentage = (double)numsDivideBy3Mod0 / n * 100;
double numsDividedBy4Mod0Percentage = (double)numsDivideBy4Mod0 / n * 100;

Console.WriteLine($"{numsDividedBy2Mod0Percentage:F2}%");
Console.WriteLine($"{numsDividedBy3Mod0Percentage:F2}%");
Console.WriteLine($"{numsDividedBy4Mod0Percentage:F2}%");