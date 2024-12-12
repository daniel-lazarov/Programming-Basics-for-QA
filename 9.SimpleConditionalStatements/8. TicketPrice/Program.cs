string ticketType = Console.ReadLine();
double studentTicketPrice = 1.00;
double regularTicketPrice = 1.60;

if (ticketType == "student")
{
    Console.WriteLine($"${studentTicketPrice:F2}");
}
else if (ticketType == "regular")
{
    Console.WriteLine($"${regularTicketPrice:F2}");
}
else
{
    Console.WriteLine("Invalid ticket type!");
}