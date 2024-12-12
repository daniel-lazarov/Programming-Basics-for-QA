using System.Xml.Linq;

int[] aNumbers = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();


int outputNumbersLength = aNumbers.Length / 2;

if (aNumbers.Length % 2 != 0)
{
    // Length is odd
    outputNumbersLength++;
}

//int outputNumbersLength = aNumbers.Length % 2 == 0 ?
//    aNumbers.Length / 2 : aNumbers.Length + 1;

int[] outputNumbers = new int[outputNumbersLength];

for (int i = 0; i < outputNumbersLength; i++)
{
    if (aNumbers.Length % 2 != 0 &&
        i == outputNumbersLength - 1)
    {
        outputNumbers[i] = aNumbers[i];
        break;
    }
   
    //Take only the current element
    int elementA = aNumbers[i];
    int elementB = aNumbers[aNumbers.Length - 1 - i];
    outputNumbers[i] = elementA + elementB;
  
}

Console.WriteLine(string.Join(" ", outputNumbers));