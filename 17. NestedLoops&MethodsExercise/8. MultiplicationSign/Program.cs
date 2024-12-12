int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 = int.Parse(Console.ReadLine());

int result = MultiplicationSign(number1, number2, number3);
//Console.WriteLine(result);

static int MultiplicationSign(int number1, int number2, int number3)
{

    int product = number1 * number2 * number3;

    if (product < 0)
    {
        Console.WriteLine("negative");
    }
    else if (product > 0)
    {
        Console.WriteLine("positive");
    }
    else
    {
        Console.WriteLine("zero");
    }
    return product;
}