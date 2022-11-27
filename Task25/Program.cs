// 1.Принимает два числа А и Б.
// 2. Чисоло А возводится в натуральную степень Б.
Console.WriteLine("Enter number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number B: ");
int b = Convert.ToInt32(Console.ReadLine());
int Degree(int x, int y)
{
    int count = 1;
    int deg = 0;
    while (deg < y)
    {
        count = count * x;
        deg++;
    }
    return count;

}
if (b > 0)
{
    int ab = Degree(a, b);
    Console.WriteLine($"Number {a} is a degree {b} = {ab}");
}
else Console.WriteLine("Введите положительное число B.");

