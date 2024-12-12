string season = Console.ReadLine();
string accomodation = Console.ReadLine();
int days = int.Parse(Console.ReadLine());

double discount = 0;
double pricePerNight = 0;

if (season == "Spring")
{
    discount = 0.2;

    if (accomodation == "Hotel")
    {
        pricePerNight = 30;
    }
    else if (accomodation == "Camping")
    {
        pricePerNight = 10;
    }
}
else if (season == "Summer")
{
    discount = 0;

    if (accomodation == "Hotel")
    {
        pricePerNight = 50;
    }
    else if (accomodation == "Camping")
    {
        pricePerNight = 30;
    }
}
else if (season == "Autumn")
{
    discount = 0.3;

    if (accomodation == "Hotel")
    {
        pricePerNight = 20;
    }
    else if (accomodation == "Camping")
    {
        pricePerNight = 15;
    }
}
else if (season == "Winter")
{
    discount = 0.1;

    if (accomodation == "Hotel")
    {
        pricePerNight = 40;
    }
    else if (accomodation == "Camping")
    {
        pricePerNight = 10;
    }
}

double expensesWoDiscount = days * pricePerNight;
double expensesTotal = expensesWoDiscount - (expensesWoDiscount * discount);
Console.WriteLine($"{expensesTotal:F2}");