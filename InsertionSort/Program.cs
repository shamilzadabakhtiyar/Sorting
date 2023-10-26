// Space Complexity: O(1)
// Time Complexity: O(n^2)
void InsertionSort<T>(T[] arr) where T : IComparable
{
    for (int i = 1; i < arr.Length; i++)
    {
        T key = arr[i];
        int j = i - 1;
        while (j >= 0 && arr[j].CompareTo(key) > 0)
        {
            arr[j + 1] = arr[j];
            j--;
        }
        arr[j + 1] = key;
    }
}

int[] arr = { 9, 8, 7, 6, 5 };
InsertionSort(arr);
Console.WriteLine(string.Join(',', arr));

//1 0 - 9,8,7,6,5 - 9,9,7,6,5 -> 8,9,7,6,5

//2 1 - 8,9,7,6,5 - 8,9,9,6,5
//1 0 - 8,9,9,6,5 - 8,8,9,6,5 -> 7,8,9,6,5

//3 2 - 7,8,9,6,5 - 7,8,9,9,5
//2 1 - 7,8,9,9,5 - 7,8,8,9,5
//1 0 - 7,8,8,9,5 - 7,7,8,9,5 -> 6,7,8,9,5

//4 3 - 6,7,8,9,5 - 6,7,8,9,9
//3 2 - 6,7,8,9,9 - 6,7,8,8,9
//2 1 - 6,7,8,8,9 - 6,7,7,8,9
//1 0 - 6,7,7,8,9 - 6,6,7,8,9 -> 5,6,7,8,9