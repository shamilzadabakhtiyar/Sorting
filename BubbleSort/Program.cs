// Space Complexity: O(1)
// Time Complexity: O(n^2)
void BubbleSort<T>(T[] arr) where T : IComparable
{
    for (int i = 0; i < arr.Length - 1; i++)
        for (int j = 0; j < arr.Length - i - 1; j++)
            if (arr[j].CompareTo(arr[j + 1]) > 0)
                (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]); // tuple deconstruction
}

int[] arr = { 9, 8, 7, 6, 5 };
BubbleSort(arr);
Console.WriteLine(string.Join(',', arr));

//0 1 - [9,8],7,6,5 -> 8,9,7,6,5
//1 2 - 8,[9,7],6,5 -> 8,7,9,6,5
//2 3 - 8,7,[9,6],5 -> 8,7,6,9,5
//3 4 - 8,7,6,[9,5] -> 8,7,6,5,9

//0 1 - [8,7],6,5,9 -> 7,8,6,5,9
//1 2 - 7,[8,6],5,9 -> 7,6,8,5,9
//2 3 - 7,6,[8,5],9 -> 7,6,5,8,9

//0 1 - [7,6],5,8,9 -> 6,7,5,8,9
//1 2 - 6,[7,5],8,9 -> 6,5,7,8,9

//0 1 - [6,5],7,8,9 -> 5,6,7,8,9