int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

Console.WriteLine(Area(width, length));

static int Area (int width, int length)
{
    int area = width * length;
    return area;
}