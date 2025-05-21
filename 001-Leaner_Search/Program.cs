// See https://aka.ms/new-console-template for more information

List<int> Sorted = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine($"Index of 7 in list of (Leaner_Search)[{string.Join(", ", Sorted)}] is " + Leaner_search(Sorted, 7));

static int Leaner_search(List<int> ints, int target)
{
    for (int i = 0; i < ints.Count; i++)
    {
        if (ints[i] == target)
            return i;
    }
    return -1;
}