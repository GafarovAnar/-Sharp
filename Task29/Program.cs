// 1.Задает массив.
// 2.Выводит массив на экран.
System.Console.WriteLine("Enter the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
void Array(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        arr[i] = rnd.Next(1, 100);
    }
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
Array(array);
PrintArray(array);