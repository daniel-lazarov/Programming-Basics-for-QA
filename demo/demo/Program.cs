static string GetTextRepresentationOfDigit(int digit)
{
    switch (digit)
    {
        case 0:
            return "zero";
            break;
        case 1:
            return "one";
            break;
        case 2:
            return "two";
            break;
        case 3:
            return "three";
            break;
        case 4:
            return "four";
            break;
        case 5:
            return "five";
            break;
        case 6:
            return "six";
            break;
        case 7:
            return "seven";
            break;
        case 8:
            return "eight";
            break;
        case 9:
            return "nine";
            break;
        default:
            return string.Empty;
    }
}

int number = int.Parse(Console.ReadLine());

while (number > 0)
{
    int lastDigit = number % 10;

    string digitText = GetTextRepresentationOfDigit(lastDigit);
    Console.WriteLine(digitText);

    number /= 10;
}


/*
while (number > 0)
{
    int lastDigit = number % 10;
    
    switch (lastDigit)
    {
        case 0:
            Console.WriteLine("zero");
            break;
        case 1:
            Console.WriteLine("one");
            break;
        case 2:
            Console.WriteLine("two");
            break;
        case 3:
            Console.WriteLine("three");
            break;
        case 4:
            Console.WriteLine("four");
            break;
        case 5:
            Console.WriteLine("five");
            break;
        case 6:
            Console.WriteLine("six");
            break;
        case 7:
            Console.WriteLine("seven");
            break;
        case 8:
            Console.WriteLine("eight");
            break;
        case 9:
            Console.WriteLine("nine");
            break;
    }

    number /= 10;
}*/