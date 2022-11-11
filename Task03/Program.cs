// Нахождение дня недели
// 1.Принимает число на ввод.
// 2.Сообщает какой день недели.
Console.WriteLine("Введите число для определения дня недели : ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine($"{number} день недели - Понедельник");
}
else if (number == 2)
{
    Console.WriteLine($"{number} день недели - Вторник");
}
else if (number == 3)
{
    Console.WriteLine($"{number} день недели - Среда");
}
else if (number == 4)
{
    Console.WriteLine($"{number} день недели - Четверг");

}
else if (number == 5)
{
    Console.WriteLine($"{number} день недели - Пятница");
}
else if (number == 6)
{
    Console.WriteLine($"{number} день недели - Суббота");
}
else if (number == 7)
{
    Console.WriteLine($"{number} день недели - Воскресенье");
}
else
{
    Console.WriteLine("Такого дня недели нет");
}