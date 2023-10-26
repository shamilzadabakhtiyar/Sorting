// Space Complexity: O(1)
// Time Complexity: O(n*logn)
void HeapSort<T>(T[] arr) where T : IComparable
{
    int length = arr.Length;

    // Build heap
    for (int i = length / 2 - 1; i >= 0; i--)
        Heapify(arr, length, i);

    // One by one extract an element from heap
    for (int i = length - 1; i >= 0; i--)
    {
        // Swap
        (arr[i], arr[0]) = (arr[0], arr[i]);

        // Heapify root element
        Heapify(arr, i, 0);
    }
}

void Heapify<T>(T[] arr, int length, int i) where T : IComparable
{
    int largest = i; // Initialize largest as root
    int left = 2 * i + 1;
    int right = 2 * i + 2;

    // If left child larger than root
    if (left < length && arr[left].CompareTo(arr[largest]) > 0)
        largest = left;

    // If right child is larger than largest so far
    if (right < length && arr[right].CompareTo(arr[largest]) > 0)
        largest = right;

    // If largest is not root
    if (largest != i)
    {
        // Swap
        (arr[largest], arr[i]) = (arr[i], arr[largest]);

        // Recursively heapify the affected sub-tree
        Heapify(arr, length, largest);  
    }

}

int[] arr = { 9, 8, 7, 6, 5 };
HeapSort(arr);
Console.WriteLine(string.Join(',', arr));
