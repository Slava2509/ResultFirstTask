string[] array = new string[5] { "Russia", "leo", "hello", "0-", ":)s" };
string[] arrEl = new string[array.Length];
void ArrayWithThreeEl(string[] arr1, string[] arr2)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[i] = arr1[i];
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ArrayWithThreeEl(array, arrEl);
PrintArray(arrEl);

