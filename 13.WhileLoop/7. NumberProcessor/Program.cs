int num = int.Parse(Console.ReadLine());


while (true)
{
    string command = Console.ReadLine();
    if (command == "End")
    {
        Console.WriteLine(num);
        break;
    }
    else if (command == "Inc")
    {
        num += 1;
    }
    else if (command == "Dec")
    {
        num -= 1;
    }
}