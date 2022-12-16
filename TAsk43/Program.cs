double[] Array(double meaningB1, double meaningK1, double meaningB2, double meaningK2)
{
    double[] array = new double[2];
    double x = (meaningB2 - meaningB1) / (meaningK1 - meaningK2);
    double y = meaningK1 * x + meaningB1;
    array[0] = x;
    array[1] = y;
    return array;
}
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]} ");
        else Console.WriteLine($"{arr[i]}");
    }
}
Console.WriteLine("Введите четыре числа для определения точек пересечения прямых");
double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());
double[] newArray = Array(b1, k1, b2, k2);
PrintArray(newArray);
