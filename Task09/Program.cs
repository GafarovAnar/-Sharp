//  Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа
// 1.Выводит случайное число от 10 до 99.
// 2.Показывает наибольшую цифру числа.
int number = new Random().Next(10, 100);
Console.WriteLine($"Случаное число из отрезка от 10 до 99 --> {number}");
int firstDigit = number / 10;
int secondDigit = number % 10;
if (firstDigit > secondDigit) Console.WriteLine($"Наибольшее число --> {firstDigit}");
else Console.WriteLine($"Наибольшее число --> {secondDigit}");