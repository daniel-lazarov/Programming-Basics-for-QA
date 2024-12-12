int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"Greater number: {a}");
}
else if (a == b)
{
    Console.WriteLine("a = b");
}
else
{
    Console.WriteLine($"Greater number: {b}");
}