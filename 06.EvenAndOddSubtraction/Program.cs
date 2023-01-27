int[] inputNumbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int all = 0;
for (int i = 0; i < inputNumbers.Length; i++)
{
    if (inputNumbers[i] % 2 == 0)
    {
        all += inputNumbers[i];
    }
}
Console.WriteLine(all);