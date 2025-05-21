// See https://aka.ms/new-console-template for more information


List<int> NotSorted = new List<int> { 5, 2, 9, 7, 12, 6, 9, 8, 4 };

Console.Write($"\nSort list of ASC (Bubble)[{string.Join(", ", NotSorted)}] is ");
Bubble_Sort_ACE(ref NotSorted);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(string.Join(", ", NotSorted));
Console.ForegroundColor = ConsoleColor.White;

Console.Write($"\nSort list of DESC (Bubble)[{string.Join(", ", NotSorted)}] is ");
Bubble_Sort_DESC(ref NotSorted);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(string.Join(", ", NotSorted));
Console.ForegroundColor = ConsoleColor.White;


static void Bubble_Sort_ACE(ref List<int> ints)
{
    for (int i = 1; i < ints.Count; i++)
    {
        for (int j = 0; j < ints.Count - i; j++)
        {
            if (ints[j] > ints[j + 1])
                (ints[j], ints[j + 1]) = (ints[j + 1], ints[j]);

        }
    }
}
static void Bubble_Sort_DESC(ref List<int> ints)
{
    for (int i = 1; i < ints.Count; i++)
    {
        for (int j = 0; j < ints.Count - i; j++)
        {
            if (ints[j] < ints[j + 1])
                (ints[j], ints[j + 1]) = (ints[j + 1], ints[j]);

        }
    }
}