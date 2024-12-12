string[] days = {
    "Invalid day!",
    "Monday",
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday",
    "Sunday"
};

int day = int.Parse(Console.ReadLine());

if (day >= 1 && day <= 7)
{
    Console.WriteLine(days[day]);
}
else
{
    Console.WriteLine(days[0]);
}