string input = Console.ReadLine();

while (input != "End")
{
    int n = int.Parse(input);
    int sum = 0;


    while (n > 0)
    {
        int digit = n % 10;
        sum += digit;
        n /= 10;
    }
    Console.WriteLine($"Sum of digits = {sum}");
    input = Console.ReadLine();
}

Console.WriteLine("Goodbye");