string movieType = (Console.ReadLine());
int rowsCount = int.Parse(Console.ReadLine());
int seatsPerRow = int.Parse(Console.ReadLine());

double seatPrice = 0;

if (movieType == "Premiere")
{
    seatPrice = 12.00;
}
else if (movieType == "Normal")
{
    seatPrice = 7.50;
}
else if (movieType == "Discount")
{
    seatPrice = 5.00;
}

double totalPrice = rowsCount * seatsPerRow * seatPrice;
Console.WriteLine($"{totalPrice:F2}");