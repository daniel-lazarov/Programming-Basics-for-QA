﻿int hour = int.Parse(Console.ReadLine());
string day = Console.ReadLine();

if ((day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday") &&
    (hour >= 10 && hour <= 18))
{
    Console.WriteLine("open");
}
else
{
    Console.WriteLine("closed");
}