// Space Complexity: O(n)
// Time Complexity: O(n*logn)
void MergeSort<T>(T[] arr, int left, int right) where T : IComparable
{
    if (left < right)
    {
        int middle = left + (right - left) / 2;

        MergeSort(arr, left, middle);
        MergeSort(arr, middle + 1, right);
        Merge(arr, left, middle, right);
    }
}

void Merge<T>(T[] arr, int left, int middle, int right) where T : IComparable
{
    int n1 = middle - left + 1;
    int n2 = right - middle;

    T[] leftArray = new T[n1];
    T[] rightArray = new T[n1];

    Array.Copy(arr, left, leftArray, 0, n1);
    Array.Copy(arr, middle + 1, rightArray, 0, n2);

    int leftIndex = 0, rightIndex = 0;
    int k = left;

    while (leftIndex < n1 && rightIndex < n2)
    {
        if (leftArray[leftIndex].CompareTo(rightArray[rightIndex]) <= 0)
        {
            arr[k] = leftArray[leftIndex];
            leftIndex++;
        }
        else
        {
            arr[k] = rightArray[rightIndex];
            rightIndex++;
        }
        k++;
    }

    Array.Copy(leftArray, leftIndex, arr, k, n1 - leftIndex);
    Array.Copy(rightArray, rightIndex, arr, k, n2 - rightIndex);
}

int[] arr = { 9, 8, 7, 6, 5 };
MergeSort(arr, 0, arr.Length - 1);
Console.WriteLine(string.Join(',', arr));
