//  Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
// 1.Принимает число на ввод.
// 2.Выводит четные числа.
Console.WriteLine("Введите число для определения всех чётных чисел от 1 до N.");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (count < number-1)
{
    count = count +2;
    Console.Write($"{count}, ");
}