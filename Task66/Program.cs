Console.WriteLine("Введите начальное число M:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальное число M:");
int number2 = Convert.ToInt32(Console.ReadLine());
SumNaturalNumbers(number1, number2, 0);
void SumNaturalNumbers(int numberM, int numberN, int sum)
{
    if (numberM > numberN)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + numberM;
    SumNaturalNumbers(numberM + 1, numberN, sum);
}