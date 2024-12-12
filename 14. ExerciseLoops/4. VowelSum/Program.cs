int n = int.Parse(Console.ReadLine());
int letterNumber = 0;
int sumChar = 0;

for (int i = 0; i < n; i++)
{
    string charLetter = Console.ReadLine();
    charLetter = charLetter.ToLower();
    
    if (charLetter == "a")
    {
        letterNumber = 1;
        sumChar += letterNumber;
    }
    else if (charLetter == "e")
    {
        letterNumber = 2;
        sumChar += letterNumber;
    }
    else if (charLetter == "i")
    {
        letterNumber = 3;
        sumChar += letterNumber;
    }
    else if (charLetter == "o")
    {
        letterNumber = 4;
        sumChar += letterNumber;
    }
    else if (charLetter == "u")
    {
        letterNumber = 5;
        sumChar += letterNumber;
    }
}

Console.WriteLine(sumChar);