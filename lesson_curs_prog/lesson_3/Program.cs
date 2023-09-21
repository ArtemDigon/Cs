int[] arr = {1,5,4,3,2,6,7};
SortArray();
PrintArray();

int MinIndex(int index)
{
    int minIndex = index;
    for (int i = index + 1; i < arr.Length; i++) {
        if (arr[i] < arr[minIndex]) minIndex = i;
    }
    return minIndex;
}

void PrintArray() {
    for (int i = 0; i < arr.Length;i++) {
        Console.WriteLine(arr[i]);
    }
}
void SwapDigits(int firstPossion, int secondPossion)
{
    int buffer;
    buffer = arr[firstPossion];
    arr[firstPossion] = arr[secondPossion];
    arr[secondPossion] = buffer;
}

void SortArray()
{
    int minInd;
    int length = arr.Length;
    for (int i = 0; i < length-1; i++){
        minInd = MinIndex(i);
        SwapDigits(i,minInd);
    }
}
