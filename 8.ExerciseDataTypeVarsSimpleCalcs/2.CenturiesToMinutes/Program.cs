int centuries = int.Parse(Console.ReadLine());
int centToYears = centuries * 100;
double yearsToDays = (int)Math.Floor(centToYears * 365.2422);
double daysToHours = yearsToDays * 24;
double hoursToMins = daysToHours * 60;

Console.WriteLine($"{centuries} centuries = {centToYears} years = {yearsToDays} days = {daysToHours} hours = {hoursToMins} minutes");