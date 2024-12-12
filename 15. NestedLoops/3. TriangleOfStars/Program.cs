int size = int.Parse(Console.ReadLine());

/*for (int i = 1; i <= size; i++)
{
    for (int s = 1; s <= i; s++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

*/

for (int i = 1; i <= size; i++)
{
    Console.WriteLine(new string('*', i));
}