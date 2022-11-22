// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// 1.Принимает числа на ввод.
// 2.Находит расстояние между точками.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите координаты Х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Х2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double Distance(int xc1, int yc1, int zc1, int xc2, int yc2, int zc2)
{
    double x3 = (xc1 - xc2) * (xc1 - xc2);
    double y3 = (yc1 - yc2) * (yc1 - yc2);
    double z3 = (zc1 - zc2) * (zc1 - zc2);
    double result = Math.Sqrt(x3 + y3 + z3);
    return result;
}
double number = Distance(x1, y1, z1, x2, y2, z2);
double arround = Math.Round(number, 2, MidpointRounding.ToZero);
Console.WriteLine(arround);