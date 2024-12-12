int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = int.Parse(Console.ReadLine());

/*
int minNumber = int.MaxValue;
int maxNumber = int.MinValue;

for (int i = 0; i < n; i++)
{
    if (numbers[i] > maxNumber)
    {
        maxNumber = numbers[i];
    }
    if (numbers[i] < minNumber)
    {
        minNumber = numbers[i];
    }
}
*/

int minNumber = numbers.Min();
int maxNumber = numbers.Max();

/*
int[] newNumbers = new int[n];
for (int i = 0; i < newNumbers.Length; i++)
{
    newNumbers[i] = numbers[i];
}*/
int[] newNumbers = numbers.Take(n).ToArray();

Console.WriteLine(newNumbers.Max());
Console.WriteLine(newNumbers.Min());