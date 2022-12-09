// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
// 1.Задать массив вещественных чисел
// 2.Напечатать массив
// 3.Найти максимум
// 4.Найти минимум
// 5.Найти разаницу.
double[] FillArray(int s)
{
    double[] arr = new double[s];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble()*3, 2,MidpointRounding.AwayFromZero);

    }
    return arr;
}
void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}
double FindMaxNumber(double[] arr)
{
    double max=arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i]) max=arr[i];
    }
   return max;
}
double FindMinNumber(double[] arr)
{
    double min=arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i]) min=arr[i];
    }
   return min;
}
double FindDiffirent ( double num1, double num2)
{
    double dif = num1-num2;
    dif = Math.Round(dif, 2,MidpointRounding.AwayFromZero);
    return dif;
}
double[] array = FillArray(6);
PrintArray(array);
double ma= FindMaxNumber(array);
double mi= FindMinNumber(array);
double count = FindDiffirent(ma,mi);
Console.WriteLine(count);

