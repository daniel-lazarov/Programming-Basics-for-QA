string text = Console.ReadLine();

int sumUpperCaseLetter = 0;
int sumLowerCaseLetter = 0;
int sumWhiteSpace = 0;

foreach (char currentChar in text)
{
    if (char.IsUpper(currentChar))
    {
        sumUpperCaseLetter++;
    }
    if (char.IsLower(currentChar))
    {
        sumLowerCaseLetter++;
    }
    if (char.IsWhiteSpace(currentChar))
    {
        sumWhiteSpace++;
    }

}

Console.WriteLine(sumUpperCaseLetter);
Console.WriteLine(sumLowerCaseLetter);
Console.WriteLine(sumWhiteSpace);