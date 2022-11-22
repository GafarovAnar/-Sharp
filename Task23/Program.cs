// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 1.Принимает число.
// 2.Выдает таблицу кубов.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
void Coub(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i}|{i * i * i}");
    }
}
Coub(number);