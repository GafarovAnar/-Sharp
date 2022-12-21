// Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
int[,] FillMatrixRndInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}
int FindForIndexTheNumber (int [,] matrix, int rows, int columns)
{
    return matrix[rows, columns];
}
Console.WriteLine("Введите размер массива: ");
int rw= Convert.ToInt32(Console.ReadLine());
int cl= Convert.ToInt32(Console.ReadLine());
int[,] newMatrix = FillMatrixRndInt(rw, cl);
PrintMatrix(newMatrix);
Console.WriteLine("Введите индекс числа: ");
int x= Convert.ToInt32(Console.ReadLine());
int y= Convert.ToInt32(Console.ReadLine());
if (x<rw || y<cl) Console.WriteLine(FindForIndexTheNumber(newMatrix,x,y));
else Console.WriteLine($"Такого элемента с индексом {x} и {y} нет.");



