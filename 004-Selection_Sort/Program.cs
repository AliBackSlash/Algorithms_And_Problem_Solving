// See https://aka.ms/new-console-template for more information

var NotSorted = new List<int> { 5, 12, 6, 9 };
Console.Write($"\nSort list of ASC (Selection)[{string.Join(", ", NotSorted)}] is ");
Selection_Sort_ASC(ref NotSorted);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(string.Join(", ", NotSorted));
Console.ForegroundColor = ConsoleColor.White;

Console.Write($"\nSort list of DESC (Selection)[{string.Join(", ", NotSorted)}] is ");
Selection_Sort_DESC(ref NotSorted);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(string.Join(", ", NotSorted));
Console.ForegroundColor = ConsoleColor.White;

static void Selection_Sort_ASC(ref List<int> ints)
{
    int MiniIndex = 0;
    for (int i = 0; i < ints.Count - 1; i++)
    {
        MiniIndex = i;
        for (int j = i; j < ints.Count; j++)
        {
            if (ints[j] < ints[MiniIndex])
            {
                MiniIndex = j;
            }
        }
        if (MiniIndex != i)
            (ints[i], ints[MiniIndex]) = (ints[MiniIndex], ints[i]);
    }
}
static void Selection_Sort_DESC(ref List<int> ints)
{
    int MaxIndex = 0;
    for (int i = 0; i < ints.Count - 1; i++)
    {
        MaxIndex = i;
        for (int j = i; j < ints.Count; j++)
        {
            if (ints[j] > ints[MaxIndex])
            {
                MaxIndex = j;
            }
        }
        if (MaxIndex != i)
            (ints[i], ints[MaxIndex]) = (ints[MaxIndex], ints[i]);
    }
}

