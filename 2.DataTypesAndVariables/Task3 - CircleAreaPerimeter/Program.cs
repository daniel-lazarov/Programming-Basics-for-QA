double radius = double.Parse(Console.ReadLine());
double pi = Math.PI;
double area = radius * radius * pi;
double perimeter = 2 * pi * radius;
Console.WriteLine($"Area = {area:F2}");
Console.WriteLine($"Perimeter = {perimeter:F2}");