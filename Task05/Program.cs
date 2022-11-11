// Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 1.Принимает на вход число.
// 2.На выходе показывает все целые числа от -N до N.
Console.WriteLine("Введите число для нахождения промежутка числе от -N до N");
int number = Convert.ToInt32(Console.ReadLine());
int n = -number;
if (number >= 0)
{
    while (n <= number)
    {
        Console.Write($"{n}, ");
        n++;
    }

}
else

{
    while (n >= number)
    {
        Console.Write($"{n}, ");
        n--;
    }
}
