string[] arrA = new string[4] { "Hello", "2", "world", ":-)" };
string[] arrB = new string[arrA.Length];

void ArrayAfterSelection(string[] arrA, string[] arrB)
{
    int count = 0;
    for (int i = 0; i < arrA.Length; i++)
    {
        if (arrA[i].Length <= 3)
        {
            arrB[count] = arrA[i];
            count++;
        }
    }
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
ArrayAfterSelection(arrA, arrB);
PrintArray(arrB);