int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

if (numbers.Length % 2 == 0)
{
    int middleIndex1 = numbers.Length / 2 - 1;
    int middleIndex2 = numbers.Length / 2;
    
    double resultAverage = (numbers[middleIndex1] + numbers[middleIndex2]) / 2.0;

    Console.WriteLine($"{resultAverage:F2}");
}