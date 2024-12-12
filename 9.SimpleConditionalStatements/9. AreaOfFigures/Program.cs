string figureType = Console.ReadLine();

if (figureType == "square")
{
    double squareSide = double.Parse(Console.ReadLine());

    double squareArea = squareSide * squareSide;

    Console.WriteLine($"{squareArea:F2}");
}
else if (figureType == "rectangle")
{
    double rectangleWidth = double.Parse(Console.ReadLine());
    double rectangleLenght = double.Parse(Console.ReadLine());

    double rectangleArea = rectangleWidth * rectangleLenght;

    Console.WriteLine($"{rectangleArea:F2}");
}
else if (figureType == "circle")
{
    double circleRadius = double.Parse(Console.ReadLine());

    double circleArea = Math.PI * circleRadius * circleRadius;

    Console.WriteLine($"{circleArea:F2}");
}