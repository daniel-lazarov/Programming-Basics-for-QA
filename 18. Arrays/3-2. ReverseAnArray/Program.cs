﻿int size = int.Parse(Console.ReadLine());

int[] numbers = new int[size];

for (int i = numbers.Length - 1; i >= 0; i--)
{
    numbers[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine(string.Join(" ", numbers));