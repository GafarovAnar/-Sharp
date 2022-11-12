// Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.
// 1.На вход принимает два числа.
// 2.Найти min и max.
Console.WriteLine("Введите первое число для сравнения : ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число для сравнения : ");
int num2 = Convert.ToInt32(Console.ReadLine());
int min = 0, max = 0;
if (num1 > num2)
{
    max = num1;
    min = num2;
    Console.WriteLine($"Наибольшее число - {max}, наименьшее число - {min}");
}
else
{
    max = num2;
    min = num1;
    Console.WriteLine($"Наибольшее число - {max}, наименьшее число - {min}");
}