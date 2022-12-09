// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// 1.Одномернный массив случайными числами.
// 2.Вывести.
// 3.Найти сумму элементов на нечётных позициях.
int[] FillArray(int s)
{
    int[] arr = new int[s];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(10, 100);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }

    Console.WriteLine("]");
}
int countEvenDigits(int[] arr)
{
    int countDigits = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1) countDigits = countDigits + arr[i];
    }
    return countDigits;
}
System.Console.WriteLine("Enter the size array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);
PrintArray(array);
int count = countEvenDigits(array);
Console.WriteLine($"Сумма чисел на нечетных позициях = {count}");