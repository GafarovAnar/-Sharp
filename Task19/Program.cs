// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 1.Принимает пятизначное число.
// 2.Проверяет на палидром.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите пятизначное число для проверки на палиндром: ");
int number = Convert.ToInt32(Console.ReadLine());
void CheckNumber(int num)
{
    if (9999 < num && num < 100000)
    return;
    Console.WriteLine("Не пятизначное число");
}

void IsPalindrom(int num)
{
    if (num / 10000 == num % 10 && (num / 1000) % 10 == (num % 100) / 10)
        Console.WriteLine("Палиндром");
        else Console.WriteLine("Не палиндром");
}
CheckNumber(number);
IsPalindrom(number);