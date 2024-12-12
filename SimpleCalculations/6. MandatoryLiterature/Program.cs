int numberOfPages = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int daysToRead = int.Parse(Console.ReadLine());

int totalHours = numberOfPages / pagesPerHour;
int hoursPerDay = totalHours / daysToRead;

Console.WriteLine(hoursPerDay);