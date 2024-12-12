char letterStart = char.Parse(Console.ReadLine());
char letterEnd = char.Parse(Console.ReadLine());

for (char i = letterStart; i <= letterEnd; i++)
{
    Console.Write($"{i} ");
}