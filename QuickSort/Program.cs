// Time Complexity 
//                 Best/Average Case: O(n*logn)
//                 Worst Case: O(n^2)
// Space Complexity: O(1)
void QuickHoareSort<T>(T[] arr, int low, int high) where T : IComparable
{
    if (low < high)
    {
        var partitiomIndex = PartitionHoare(arr, low, high);
        QuickHoareSort(arr, low, partitiomIndex);
        QuickHoareSort(arr, partitiomIndex + 1, high);
    }
}

void QuickLomutoSort<T>(T[] arr, int low, int high) where T : IComparable
{
    if (low < high)
    {
        var partitiomIndex = PartitionLomuto(arr, low, high);
        QuickLomutoSort(arr, low, partitiomIndex - 1);
        QuickLomutoSort(arr, partitiomIndex + 1, high);
    }
}

int PartitionHoare<T>(T[] arr, int low, int high) where T : IComparable
{
    var pivot = arr[low];
    int i = low - 1, j = high + 1;

    while (true)
    {
        do
        {
            i++;
        } while (arr[i].CompareTo(pivot) < 0);

        do
        {
            j++;
        }
        while (arr[j].CompareTo(pivot) > 0);

        if (i >= j) return j;

        (arr[i], arr[j]) = (arr[j], arr[i]);
    }
}

int PartitionLomuto<T>(T[] arr, int low, int high) where T : IComparable
{
    var pivot = arr[high];
    int i = low - 1;

    while (true)
    {
        for (int j = low; j < high; j++)
        {
            if (arr[j].CompareTo(pivot) < 0)
            {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }
        (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
        return i + 1;
    }
}

int[] arr = { 9, 8, 7, 6, 5 };
//QuickHoareSort(arr, 0, arr.Length);
QuickLomutoSort(arr, 0, arr.Length);
Console.WriteLine(string.Join(',', arr));
