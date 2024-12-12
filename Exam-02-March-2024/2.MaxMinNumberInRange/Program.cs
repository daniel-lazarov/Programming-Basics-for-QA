int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int startIndex = int.Parse(Console.ReadLine());
int endIndex = int.Parse(Console.ReadLine());

int max = numbers[startIndex];
int min = numbers[startIndex];

for (int i = startIndex; i <= endIndex; i++)
{
    int number = numbers[i];
    if (max < number)
    {
        max = number;
    }
}

for (int i = startIndex; i <= endIndex; i++)
{
    int number = numbers[i];
    if (number < min)
    {
        min = number;
    }
}

Console.WriteLine(min+max);

//Console.WriteLine(max);
//Console.WriteLine(min);