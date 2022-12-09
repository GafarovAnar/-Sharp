// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// 1.Создать массив заполненный случайными трехзначными числами.
// 2. Напечтать массив.
// 3. Количество четных чисел.
int[] FillArray(int s)
{
    int[] arr = new int[s];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
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
int CountEvenNumber( int [] arr)
{
    int countEvenNumber=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2==0) countEvenNumber+=1;
    }
    return countEvenNumber;
}
Console.WriteLine("Введите длину массива: ");
int size=Convert.ToInt32(Console.ReadLine());
int [] array = FillArray(size);
int count = CountEvenNumber(array);
PrintArray(array);
Console.WriteLine($"Колличество четных чисел в массиве {count}"); 