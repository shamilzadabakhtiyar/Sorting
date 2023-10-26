// Space Complexity: O(1)
// Time Complexity: O(n^2)
void SelectionSort<T>(T[] arr) where T : IComparable
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minIndex = i;
        for (int j = i + 1; j < arr.Length; j++)
            if (arr[j].CompareTo(arr[minIndex]) < 0)
                minIndex = j;
        (arr[minIndex], arr[i]) = (arr[i], arr[minIndex]); // tuple deconstruction
    }
}

int[] arr = { 9, 8, 7, 6, 5 };
SelectionSort(arr);
Console.WriteLine(string.Join(',', arr));

//0 1 - 9,8,7,6,5 -> 8,9,7,6,5
//0 2 - 8,9,7,6,5 -> 7,9,8,6,5
//0 3 - 7,9,8,6,5 -> 6,9,8,7,5
//0 4 - 6,9,8,7,5 -> 5,9,8,7,6

//1 2 - 5,9,8,7,6 -> 5,8,9,7,6
//1 3 - 5,8,9,7,6 -> 5,7,9,8,6
//1 4 - 5,7,9,8,6 -> 5,6,9,8,7

//2 3 - 5,6,9,8,7 -> 5,6,8,9,7
//2 4 - 5,6,8,9,7 -> 5,6,7,9,8

//3 4 - 5,6,7,9,8 -> 5,6,7,8,9