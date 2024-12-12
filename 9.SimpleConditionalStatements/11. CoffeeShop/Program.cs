string drinkName = Console.ReadLine();
string extra = Console.ReadLine();

if (drinkName == "coffee")
{
    if (extra == "sugar")
    {
        Console.WriteLine($"Final price: $1.40");
    }
    else
    {
        Console.WriteLine($"Final price: $1.00");
    }
}
else if (drinkName == "tea")
{
    if (extra == "sugar")
    {
        Console.WriteLine($"Final price: $1.00");
    }
    else
    {
        Console.WriteLine($"Final price: $0.60");
    }
}