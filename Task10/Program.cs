bool CheckNumber(int num)
{
    return (num < 1000) && (num > 99);
}
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine(CheckNumber(number) ? $"Третья цифра числа {number} --> {(number/10)%10}" : "Число не трехзначное");