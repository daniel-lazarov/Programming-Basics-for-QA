string text = Console.ReadLine();

int vowelsCount = VowelsCountInText(text);

Console.WriteLine(vowelsCount);

static int VowelsCountInText(string text)
{
    int vowelsCount = 0;
    for (int i = 0; i <= text.Length -1 ; i++)
    {
        char ch = char.ToLower(text[i]);
        if (ch == 'a' || ch == 'e' || ch == 'o' || ch == 'u' || ch == 'i')
        {
            vowelsCount++;
        }
    }

    return vowelsCount;
}