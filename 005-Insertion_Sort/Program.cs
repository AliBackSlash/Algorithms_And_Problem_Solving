// See https://aka.ms/new-console-template for more information

var NotSorted = new List<int> { 2, 4, 3, 1 };
Console.Write($"\nSort list of ASC (Insertion)[{string.Join(", ", NotSorted)}] is ");
Insertion_Sort_ASC(ref NotSorted);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(string.Join(", ", NotSorted));
Console.ForegroundColor = ConsoleColor.White;

Console.Write($"\nSort list of DESC (Insertion)[{string.Join(", ", NotSorted)}] is ");
Insertion_Sort_DESC(ref NotSorted);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(string.Join(", ", NotSorted));
Console.ForegroundColor = ConsoleColor.White;

static void Insertion_Sort_ASC(ref List<int> ints)
{
    int n = ints.Count;
    for (int i = 1; i < n; ++i)
    {
        int key = ints[i];
        int j = i - 1;


        while (j >= 0 && ints[j] > key)
        {
            ints[j + 1] = ints[j];
            j -= 1;
        }
        ints[j + 1] = key;
    }
}
static void Insertion_Sort_DESC(ref List<int> ints)
{
    int n = ints.Count;
    for (int i = 1; i < n; ++i)
    {
        int key = ints[i];
        int j = i - 1;


        while (j >= 0 && ints[j] < key)
        {
            ints[j + 1] = ints[j];
            j = j - 1;
        }
        ints[j + 1] = key;
    }
}

