// Space Complexity: O(n)
// Time Complexity: O(n^2)
void SelectionSort<T>(T[] arr) where T : IComparable
{
    for (int i = 0; i < arr.Length; i++)
    {
        int minIndex = i;
        for (int j = i + 1; j < arr.Length; j++)
            if (arr[j].CompareTo(arr[minIndex]) < 0)
                minIndex = j;
        (arr[minIndex], arr[i]) = (arr[i], arr[minIndex]); // tuple deconstruction
    }
}

int[] arr = { 1, 9, 2, 8 };
SelectionSort(arr);
Console.WriteLine(string.Join(',', arr));