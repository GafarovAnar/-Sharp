// 1.На вход принимает число.
// 2.Выдает сумму чисел.
System.Console.WriteLine("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
int Sum(int num)
{
    int count = 0;
    if (num < 0) num = -1 * num;
    while (num > 0)
    {
        count = count + num % 10;
        num /= 10;
    }
    return count;

}
int sum = Sum(number);
Console.WriteLine($"Sum of numbers {number} -> {sum}");


