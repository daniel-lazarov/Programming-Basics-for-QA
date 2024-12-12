int N1 = int.Parse(Console.ReadLine());
int N2 = int.Parse(Console.ReadLine());

int factorialN1 = Factorial(N1);
int factorialN2 = Factorial(N2);
int divisionResult = factorialN1 / factorialN2;

Console.WriteLine($"{divisionResult}");

static int Factorial(int number)
{
    int factorial = 1;
    for (int i = 1; i <= number; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}