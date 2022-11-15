// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 1.Выводит число от 100 до 999.
// 2.Удаляет вторую цифру.
// 456 -> 46
int CountDigit(int num)
{
    int firstDigit=num/100;
    int lastDigit=num%10;
    int count=firstDigit*10+lastDigit;
    return count;
}
int number= new Random().Next(100,1000);
Console.WriteLine($"Случайное число от 100 до 999 --> {number}");
Console.WriteLine(CountDigit(number));