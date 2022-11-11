// Проверка целого числа на его квадрат.
// 1.На вход принимает два числ.
// 2.Является ли первое число квадратом второго.
Console.WriteLine("Введите два числа для проверки соответсвия квадрата : ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int square = num1 * num1;
if (square == num2)
{
    Console.WriteLine($"Да. Квадрат числа {num1} равен {num2}");
}
else
{
    Console.WriteLine($"Нет. Квадрат числа {num1} не равен {num2}, а равен {square}");
}