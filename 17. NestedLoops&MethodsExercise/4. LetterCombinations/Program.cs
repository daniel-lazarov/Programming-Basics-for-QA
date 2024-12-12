char s = char.Parse(Console.ReadLine());
char e = char.Parse(Console.ReadLine());
char x = char.Parse(Console.ReadLine());

int count = 0;

for (char firstLetter = s; firstLetter <= e; firstLetter++)
{
    for (char secondLetter = s; secondLetter <= e; secondLetter++)
    {
        for (char thirdLetter = s; thirdLetter <= e; thirdLetter++)
        {
            if(firstLetter != x && secondLetter != x && thirdLetter != x)
            {
                Console.Write($"{firstLetter}{secondLetter}{thirdLetter} ");
                count++;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine(count);