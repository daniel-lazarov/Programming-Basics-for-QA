int n = int.Parse(Console.ReadLine());
int p = int.Parse(Console.ReadLine());

Console.WriteLine(MathPow(n,p));

static int MathPow(int baseNum, int power)
{
    int output = baseNum;
    for (int i = 2; i <= power; i++)
    {
        output *= baseNum;
    }
    return output;
}