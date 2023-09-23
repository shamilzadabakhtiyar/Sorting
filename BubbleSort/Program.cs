// Space Complexity: O(n)
// Time Complexity: O(n^2)
void BubbleSort<T>(T[] arr) where T : IComparable
{
    for (int i = 0; i < arr.Length; i++)
        for (int j = 0; j < arr.Length - i - 1; j++)
            if (arr[j].CompareTo(arr[j + 1]) > 0)
                (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]); // tuple deconstruction
}

int[] arr = { 1, 9, 2, 8 };
BubbleSort(arr);
Console.WriteLine(string.Join(',', arr));