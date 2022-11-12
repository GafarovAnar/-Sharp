// Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.
// 1. Принимает на ввод 3 числа.
// 2.Находит максимальное.
Console.WriteLine("Введите первое число для сравнения : ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число для сравнения : ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число для сравнения : ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (num1 > num2)
{
    max = num1;
}
else
{
    max = num2;
}
if (max < num3)
{
    max = num3;
}
Console.WriteLine($"Максимальное число - {max}");
