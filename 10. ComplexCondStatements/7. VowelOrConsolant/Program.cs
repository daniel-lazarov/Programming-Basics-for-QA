char letter = char.Parse(Console.ReadLine());

/*
if (letter == 'a' || letter == 'A' || letter == 'E' || letter == 'e' ||
    letter == 'I' || letter == 'i' || letter == 'O' || letter == 'o' ||
    letter == 'U' || letter == 'u')
{
    Console.WriteLine("Vowel");
}
else
{
    Console.WriteLine("Consonant");
}

*/

switch (letter)
{
    case 'a':
    case 'A':
    case 'e':
    case 'E':
    case 'i':
    case 'I':
    case 'o':
    case 'O':
    case 'u':
    case 'U':
        Console.WriteLine("Vowel");
        break;

    default:
        Console.WriteLine("Consonant");
        break;
}