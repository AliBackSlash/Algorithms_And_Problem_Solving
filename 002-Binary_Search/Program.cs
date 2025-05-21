// See https://aka.ms/new-console-template for more information
List<int> Sorted = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine($"Index of 7 in list of (Binary_Search)[{string.Join(", ", Sorted)}] is " + Binary_Search(Sorted, 7));

static int Binary_Search(List<int> ints, int target)
{
    int Start = 0, middle = 0, End = ints.Count - 1;

    //1,2,3,4,5,6,7,8,9,10 target = 7

    while (Start <= End)
    {
        middle = Start + (End - Start) / 2;

        if (ints[middle] == target)
            return middle;
        else if (ints[middle] > target)
            End = middle - 1;
        else
            Start = middle + 1;


    }

    return -1;

}